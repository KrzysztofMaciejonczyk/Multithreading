using System.Diagnostics;
using System.Windows.Forms;

namespace ImageParalleling
{
    public partial class ImageGUI : Form
    {
        private Bitmap? _img;
        public static readonly object locker = new object();
        public ImageGUI()
        {
            InitializeComponent();
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                _img = new Bitmap(file);
                pictureBoxMain.Image = _img;
            }
        }
        private void buttonParallel_Click(object sender, EventArgs e)
        {
            if (_img == null)
            {
                throw new Exception("Error");
            }
            int numberOfThreads = 4;
            ParallelOptions options = new ParallelOptions() { MaxDegreeOfParallelism = numberOfThreads };
            Parallel.For(0, numberOfThreads, options, x =>
            {
                switch (x)
                {
                    case 0: PerformNegative(); break;
                    case 1: PerformThreshold(); break;
                    case 2: PerformMirroring(); break;
                    case 3: PerformGrayScale(); break;
                }
            });
        }
        void PerformNegative()
        {
            Bitmap filteredImage;
            lock (locker)
            {
                filteredImage = (Bitmap)_img.Clone();
            }
            int height = filteredImage.Height;
            int width = filteredImage.Width;
            Debug.WriteLine($"Height: {height}");
            Debug.WriteLine($"Width: {width}");
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color negColor = filteredImage.GetPixel(i, j);
                    int R = 255 - negColor.R;
                    int G = 255 - negColor.G;
                    int B = 255 - negColor.B;
                    Color filteredImageColor = Color.FromArgb(R, G, B);
                    filteredImage.SetPixel(i, j, filteredImageColor);
                }
            }
            pictureBoxNeg.Image = filteredImage;
        }
        void PerformThreshold()
        {
            Bitmap filteredImage;
            lock (locker)
            {
                filteredImage = (Bitmap)_img.Clone();
            }
            Bitmap temp = new Bitmap(filteredImage.Width, filteredImage.Height);
            int height = filteredImage.Height;
            int width = filteredImage.Width;
            int threshold = 165;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color initialColor = filteredImage.GetPixel(i, j);
                    //transforming to gray image
                    int grayscale = (int)(0.299 * initialColor.R + 0.587 * initialColor.G + 0.114 * initialColor.B);
                    Color grayColor = Color.FromArgb(grayscale, grayscale, grayscale);
                    temp.SetPixel(i, j, grayColor);
                    //performing thresholding operation with threshold
                    int intensity = temp.GetPixel(i, j).R >= threshold ? 255 : 0;
                    Color thresholdedColor = Color.FromArgb(intensity, intensity, intensity);
                    filteredImage.SetPixel(i, j, thresholdedColor);
                }
            }
            pictureBoxThresh.Image = filteredImage;
        }
        void PerformMirroring()
        {
            Bitmap filteredImage;
            lock (locker)
            {
                filteredImage = (Bitmap)_img.Clone();
            }
            Bitmap temp = new Bitmap(filteredImage.Width, filteredImage.Height);
            int height = filteredImage.Height;
            int width = filteredImage.Width;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color threshColor = filteredImage.GetPixel(i, j);
                    temp.SetPixel(width - 1 - i, j, threshColor);
                }
            }
            filteredImage = temp;
            pictureBoxMirror.Image = filteredImage;
        }
        void PerformGrayScale()
        {
            Bitmap filteredImage;
            lock (locker)
            {
                filteredImage = (Bitmap)_img.Clone();
            }
            Bitmap temp = new Bitmap(filteredImage.Width, filteredImage.Height);
            int height = filteredImage.Height;
            int width = filteredImage.Width;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color initialColor = filteredImage.GetPixel(i, j);
                    int grayscale = (int)(0.299 * initialColor.R + 0.587 * initialColor.G + 0.114 * initialColor.B);
                    Color grayColor = Color.FromArgb(grayscale, grayscale, grayscale);
                    filteredImage.SetPixel(i, j, grayColor);
                }
            }
            pictureBoxGray.Image = filteredImage;
        }
    }
}
