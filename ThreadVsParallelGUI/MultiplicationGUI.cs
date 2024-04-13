using System.Drawing.Drawing2D;
using LAB3;
namespace ThreadVsParallelGUI
{
    public partial class MultiplicationGUI : Form
    {
        //public static volatile int count = 0;
        private static volatile CustomMatrix resultMatrix;
        //public static readonly object locker = new object();

        internal static CustomMatrix ResultMatrix { get => resultMatrix; set => resultMatrix = value; }

        public MultiplicationGUI()
        {
            InitializeComponent();
        }

        private void buttonThread_Click(object sender, EventArgs e)
        {
            if (textBoxThreads.Text.Length > 0 && textBoxSize.Text.Length > 0)
            {
                int numberOfThreads = 4;
                try
                {
                    numberOfThreads = int.Parse(textBoxThreads.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Number of threads must be an integer.\nSetting default number to 4.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int sizeOfMatrix = 5;
                try
                {
                    sizeOfMatrix = int.Parse(textBoxSize.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Size of matrix must be an integer.\nSetting default size to 5.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxPaTime.Text = "";
                textBoxPaResult.Text = "";
                Thread[] threads = new Thread[numberOfThreads];
                CustomMatrix matrix1 = new CustomMatrix(sizeOfMatrix);
                CustomMatrix matrix2 = new CustomMatrix(sizeOfMatrix);
                ResultMatrix = new CustomMatrix(sizeOfMatrix);
                ResultMatrix.zeroMatrix();
                textBoxMatrix1.Text = matrix1.ToString();
                textBoxMatrix2.Text = matrix2.ToString();
                int rowsForThread;
                if (sizeOfMatrix % numberOfThreads == 0) // equal work for every thread means equal number of rows, no need to lengthen the work span
                {
                    rowsForThread = sizeOfMatrix / numberOfThreads;
                }
                else // lengthen the work span (every thread equal number of rows except the last one)
                {
                    rowsForThread = sizeOfMatrix / numberOfThreads + 1;
                }

                /* BASIC THREADING */

                ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(CalculateMatrix);
                for (int i = 0; i < numberOfThreads; i++)
                {
                    threads[i] = new Thread(parameterizedThreadStart);
                    threads[i].Name = String.Format("Thread: {0}", i + 1);
                }
                int ID = 0;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                foreach (Thread t in threads)
                {
                    t.Start((matrix1, matrix2, ID, rowsForThread));
                    ID++;
                }
                foreach (Thread t in threads) t.Join();
                watch.Stop();
                textBoxThTime.Text = $"{watch.ElapsedMilliseconds} ms";
                textBoxThResult.Text = ResultMatrix.ToString();
            }
            else
            {
                MessageBox.Show("Neither of the textboxes can be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static void CalculateMatrix(object parameters)
        {
            (CustomMatrix matrix1, CustomMatrix matrix2, int ID, int RPT) = ((CustomMatrix, CustomMatrix, int, int))parameters;
            for (int row = ID * RPT; row < Math.Min((ID + 1) * RPT, matrix2.getSize()); ++row)
            {
                for (int col2 = 0; col2 < matrix2.getSize(); col2++)
                {
                    for (int col1 = 0; col1 < matrix1.getSize(); col1++)
                    {
                        int finalValue = matrix1.getValues()[row, col1] * matrix2.getValues()[col1, col2];
                        ResultMatrix.getValues()[row, col2] += finalValue;

                    }
                }
            }
        }

        private void buttonParallel_Click(object sender, EventArgs e)
        {
            if (textBoxThreads.Text.Length > 0 && textBoxSize.Text.Length > 0)
            {
                int numberOfThreads = 4;
                try
                {
                    numberOfThreads = int.Parse(textBoxThreads.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Number of threads must be an integer.\nSetting default number to 4.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int sizeOfMatrix = 5;
                try
                {
                    sizeOfMatrix = int.Parse(textBoxSize.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Size of matrix must be an integer.\nSetting default size to 5.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxThTime.Text = "";
                textBoxThResult.Text = "";
                CustomMatrix matrix1 = new CustomMatrix(sizeOfMatrix);
                CustomMatrix matrix2 = new CustomMatrix(sizeOfMatrix);
                ResultMatrix = new CustomMatrix(sizeOfMatrix);
                ResultMatrix.zeroMatrix();
                textBoxMatrix1.Text = matrix1.ToString();
                textBoxMatrix2.Text = matrix2.ToString();
                int rowsForThread;
                if (sizeOfMatrix % numberOfThreads == 0) // equal work for every thread means equal number of rows, no need to lengthen the work span
                {
                    rowsForThread = sizeOfMatrix / numberOfThreads;
                }
                else // lengthen the work span (every thread equal number of rows except the last one)
                {
                    rowsForThread = sizeOfMatrix / numberOfThreads + 1;
                }

                /* PARALLEL THREADING */

                ParallelOptions options = new ParallelOptions() { MaxDegreeOfParallelism = numberOfThreads };
                var watchParallel = System.Diagnostics.Stopwatch.StartNew();
                Parallel.For(0, numberOfThreads, options, x =>
                {
                    CalculateMatrix((matrix1, matrix2, x, rowsForThread));
                });
                watchParallel.Stop();
                textBoxPaTime.Text = $"{watchParallel.ElapsedMilliseconds} ms";
                textBoxPaResult.Text = ResultMatrix.ToString();
            }
            else
            {
                MessageBox.Show("Neither of the textboxes can be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonVS_Click(object sender, EventArgs e)
        {
            if (textBoxThreads.Text.Length > 0 && textBoxSize.Text.Length > 0)
            {
                int numberOfThreads = 4;
                try
                {
                    numberOfThreads = int.Parse(textBoxThreads.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Number of threads must be an integer.\nSetting default number to 4.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                int sizeOfMatrix = 5;
                try
                {
                    sizeOfMatrix = int.Parse(textBoxSize.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Size of matrix must be an integer.\nSetting default size to 5.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                textBoxThTime.Text = "";
                textBoxThResult.Text = "";
                textBoxPaTime.Text = "";
                textBoxPaResult.Text = "";
                Thread[] threads = new Thread[numberOfThreads];
                CustomMatrix matrix1 = new CustomMatrix(sizeOfMatrix);
                CustomMatrix matrix2 = new CustomMatrix(sizeOfMatrix);
                ResultMatrix = new CustomMatrix(sizeOfMatrix);
                ResultMatrix.zeroMatrix();
                textBoxMatrix1.Text = matrix1.ToString();
                textBoxMatrix2.Text = matrix2.ToString();
                int rowsForThread;
                if (sizeOfMatrix % numberOfThreads == 0) // equal work for every thread means equal number of rows, no need to lengthen the work span
                {
                    rowsForThread = sizeOfMatrix / numberOfThreads;
                }
                else // lengthen the work span (every thread equal number of rows except the last one)
                {
                    rowsForThread = sizeOfMatrix / numberOfThreads + 1;
                }

                /* BASIC THREADING */

                ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(CalculateMatrix);
                for (int i = 0; i < numberOfThreads; i++)
                {
                    threads[i] = new Thread(parameterizedThreadStart);
                    threads[i].Name = String.Format("Thread: {0}", i + 1);
                }
                int ID = 0;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                foreach (Thread t in threads)
                {
                    t.Start((matrix1, matrix2, ID, rowsForThread));
                    ID++;
                }
                foreach (Thread t in threads) t.Join();
                watch.Stop();
                textBoxThTime.Text = $"{watch.ElapsedMilliseconds} ms";
                textBoxThResult.Text = ResultMatrix.ToString();

                /* PARALLEL THREADING */

                ResultMatrix.zeroMatrix();
                ParallelOptions options = new ParallelOptions() { MaxDegreeOfParallelism = numberOfThreads };
                var watchParallel = System.Diagnostics.Stopwatch.StartNew();
                Parallel.For(0, numberOfThreads, options, x =>
                {
                    CalculateMatrix((matrix1, matrix2, x, rowsForThread));
                });
                watchParallel.Stop();
                textBoxPaTime.Text = $"{watchParallel.ElapsedMilliseconds} ms";
                textBoxPaResult.Text = ResultMatrix.ToString();
            }
            else
            {
                MessageBox.Show("Neither of the textboxes can be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
