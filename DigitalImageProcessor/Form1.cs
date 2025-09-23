#nullable disable


using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;

namespace DigitalImageProcessor
{
    public partial class Form1 : Form
    {
        Bitmap originalImage;
        Bitmap processedImage;

        public Form1()
        {
            InitializeComponent();

            // Link menu item clicks to methods
            addImageToolStripMenuItem.Click += AddImageToolStripMenuItem_Click;
            saveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            resetToolStripMenuItem.Click += ResetToolStripMenuItem_Click;

            basicCopyToolStripMenuItem.Click += BasicCopyToolStripMenuItem_Click;
            greyscaleToolStripMenuItem.Click += GreyscaleToolStripMenuItem_Click;
            colorInversionToolStripMenuItem.Click += ColorInversionToolStripMenuItem_Click;
            sepiaToolStripMenuItem.Click += SepiaToolStripMenuItem_Click;
            histogramToolStripMenuItem.Click += HistogramToolStripMenuItem_Click;
        }

        // Add Image
        private void AddImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(ofd.FileName);
                pictureBox1.Image = originalImage;
                processedImage = null;
                pictureBox2.Image = null;
            }
        }

        // Save Image
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (processedImage == null)
            {
                MessageBox.Show("No processed image to save!");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                processedImage.Save(sfd.FileName);
            }
        }

        // Reset
        private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = originalImage;
            pictureBox2.Image = null;
            processedImage = null;
        }

        // Basic Copy
        private void BasicCopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            processedImage = new Bitmap(originalImage);
            pictureBox2.Image = processedImage;
        }

        // Greyscale
        private void GreyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color c = originalImage.GetPixel(x, y);
                    int gray = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                    processedImage.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }

            pictureBox2.Image = processedImage;
        }

        // Color Inversion
        private void ColorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color c = originalImage.GetPixel(x, y);
                    processedImage.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }

            pictureBox2.Image = processedImage;
        }

        // Sepia
        private void SepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            processedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color c = originalImage.GetPixel(x, y);
                    int tr = (int)(0.393 * c.R + 0.769 * c.G + 0.189 * c.B);
                    int tg = (int)(0.349 * c.R + 0.686 * c.G + 0.168 * c.B);
                    int tb = (int)(0.272 * c.R + 0.534 * c.G + 0.131 * c.B);

                    tr = Math.Min(255, tr);
                    tg = Math.Min(255, tg);
                    tb = Math.Min(255, tb);

                    processedImage.SetPixel(x, y, Color.FromArgb(tr, tg, tb));
                }
            }

            pictureBox2.Image = processedImage;
        }

        // Histogram (as grayscale intensity)
        private void HistogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            int[] histogram = new int[256];

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color c = originalImage.GetPixel(x, y);
                    int gray = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                    histogram[gray]++;
                }
            }

            int histHeight = 200;
            int histWidth = 256;
            Bitmap histImage = new Bitmap(histWidth, histHeight);

            int max = histogram.Max();
            for (int x = 0; x < histWidth; x++)
            {
                int h = (int)((histogram[x] / (float)max) * histHeight);
                for (int y = histHeight - 1; y >= histHeight - h; y--)
                {
                    histImage.SetPixel(x, y, Color.Black);
                }
            }

            processedImage = histImage;
            pictureBox2.Image = processedImage;
        }
    }
}
