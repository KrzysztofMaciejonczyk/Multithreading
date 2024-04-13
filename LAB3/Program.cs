using System.Drawing;

namespace LAB3
{
    internal class Program
    {
        //public static volatile int count = 0;
        public static volatile CustomMatrix resultMatrix;
        //public static readonly object locker = new object();
        public static int rowsForThread;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of threads: ");
            int numberOfThreads = 10;
            try
            {
                numberOfThreads = int.Parse(Console.ReadLine());
                if (numberOfThreads < 0)
                {
                    Console.WriteLine("Number of threads set to 10 beacuse it cannot be negative.");
                    numberOfThreads = 10;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Default number of threads set to 10.");
            }
            Console.WriteLine("Enter the size of the square matrix: ");
            int sizeOfMatrix = 10;
            try
            {
                sizeOfMatrix = int.Parse(Console.ReadLine());
                if (sizeOfMatrix < 0)
                {
                    Console.WriteLine("Size of the square matrix set to 10 beacuse it cannot be negative.");
                    sizeOfMatrix = 10;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Default size of the square matrix set to 10.");
            }
            Thread[] threads = new Thread[numberOfThreads];
            CustomMatrix matrix1 = new CustomMatrix(sizeOfMatrix);
            CustomMatrix matrix2 = new CustomMatrix(sizeOfMatrix);
            resultMatrix = new CustomMatrix(sizeOfMatrix);
            resultMatrix.zeroMatrix();
            Console.WriteLine("First matrix:");
            Console.WriteLine(matrix1.ToString());
            Console.WriteLine("Second matrix:");
            Console.WriteLine(matrix2.ToString());
            if (sizeOfMatrix%numberOfThreads == 0) // equal work for every thread means equal number of rows, no need to lengthen the work span
            {
                rowsForThread = sizeOfMatrix/numberOfThreads;
            }
            else // lengthen the work span (every thread equal number of rows except the last one)
            {
                rowsForThread = sizeOfMatrix/numberOfThreads+1;
            }

            /* BASIC THREADING */

            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(CalculateMatrix);
            for (int i = 0; i < numberOfThreads; i++)
            {
                threads[i] = new Thread(parameterizedThreadStart);
                threads[i].Name = String.Format("Thread: {0}", i+1);
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
            Console.WriteLine($"Thread: Multiple threads ended in {watch.ElapsedMilliseconds} ms.");
            Console.WriteLine("Thread: Result:");
            string resultThread = resultMatrix.ToString();
            Console.WriteLine(resultThread);

            /* PARALLEL THREADING */

            resultMatrix.zeroMatrix();
            ParallelOptions options = new ParallelOptions() { MaxDegreeOfParallelism = numberOfThreads };
            var watchParallel = System.Diagnostics.Stopwatch.StartNew();
            Parallel.For(0, numberOfThreads, options, x =>
            {
                CalculateMatrix((matrix1, matrix2, x, rowsForThread));
            });
            watchParallel.Stop();
            Console.WriteLine($"Parallel: Multiple threads ended in {watchParallel.ElapsedMilliseconds} ms.");
            string resultParallel = resultMatrix.ToString();
            Console.WriteLine("Parallel: Result:");
            Console.WriteLine(resultParallel);
            /*Creating single thread for testing purposes*/

            /*Thread singleThread = new Thread(parameterizedThreadStart);
            singleThread.Name = String.Format("Thread: Single");
            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            singleThread.Start((matrix1, matrix2, 0, 1000000));
            singleThread.Join();
            watch2.Stop();
            Console.WriteLine($"Single thread ended in {watch2.ElapsedMilliseconds} ms.");*/

            /*Checking the results*/

            /*Matrix matrix3 = matrix1 * matrix2;
            string m1 = matrix1.ToString();
            string m2 = matrix2.ToString();
            string result = matrix3.ToString();
            string thresult2 = resultMatrix.ToString();
            for (int i = 0; i < resultMatrix.getSize(); i++)
            {
                for (int j = 0; j < resultMatrix.getSize(); j++)
                {
                    if (resultMatrix.getValues()[i,j] != matrix3.getValues()[i,j])
                    {
                        Console.WriteLine("Not Equal");
                    }
                }
            }*/
            //Console.WriteLine(m1);
           // Console.WriteLine(m2);
            //Console.WriteLine(result);
            //Console.WriteLine(thresult2);
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
                            resultMatrix.getValues()[row, col2] += finalValue;
                        
                    }
                }
            }
        }
    }
}
