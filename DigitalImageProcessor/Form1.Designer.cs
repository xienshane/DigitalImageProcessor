#nullable disable


namespace DigitalImageProcessor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Controls
        private MenuStrip menuStrip1;
        private ToolStripMenuItem actionToolStripMenuItem;
        private ToolStripMenuItem addImageToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem featureToolStripMenuItem;
        private ToolStripMenuItem basicCopyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem colorInversionToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private ToolStripMenuItem imageSubtractionToolStripMenuItem;

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3; // subtraction result

        private Label label1;
        private Label label2;

        private Button btnLoadImage;
        private Button btnLoadBackground;
        private Button btnSubtract;




        /// <summary>
        /// Dispose resources
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            actionToolStripMenuItem = new ToolStripMenuItem();
            addImageToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            featureToolStripMenuItem = new ToolStripMenuItem();
            basicCopyToolStripMenuItem = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            colorInversionToolStripMenuItem = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            imageSubtractionToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            btnLoadImage = new Button();
            btnLoadBackground = new Button();
            btnSubtract = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { actionToolStripMenuItem, featureToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1550, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            actionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addImageToolStripMenuItem, saveToolStripMenuItem, resetToolStripMenuItem });
            actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            actionToolStripMenuItem.Size = new Size(66, 24);
            actionToolStripMenuItem.Text = "Action";
            // 
            // addImageToolStripMenuItem
            // 
            addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            addImageToolStripMenuItem.Size = new Size(169, 26);
            addImageToolStripMenuItem.Text = "Add Image";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(169, 26);
            saveToolStripMenuItem.Text = "Save Image";
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(169, 26);
            resetToolStripMenuItem.Text = "Reset";
            // 
            // featureToolStripMenuItem
            // 
            featureToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basicCopyToolStripMenuItem, greyscaleToolStripMenuItem, colorInversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem, imageSubtractionToolStripMenuItem });
            featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            featureToolStripMenuItem.Size = new Size(72, 24);
            featureToolStripMenuItem.Text = "Feature";
            // 
            // basicCopyToolStripMenuItem
            // 
            basicCopyToolStripMenuItem.Name = "basicCopyToolStripMenuItem";
            basicCopyToolStripMenuItem.Size = new Size(214, 26);
            basicCopyToolStripMenuItem.Text = "Basic Copy";
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(214, 26);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            // 
            // colorInversionToolStripMenuItem
            // 
            colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            colorInversionToolStripMenuItem.Size = new Size(214, 26);
            colorInversionToolStripMenuItem.Text = "Color Inversion";
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(214, 26);
            histogramToolStripMenuItem.Text = "Histogram";
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(214, 26);
            sepiaToolStripMenuItem.Text = "Sepia";
            // 
            // imageSubtractionToolStripMenuItem
            // 
            imageSubtractionToolStripMenuItem.Name = "imageSubtractionToolStripMenuItem";
            imageSubtractionToolStripMenuItem.Size = new Size(214, 26);
            imageSubtractionToolStripMenuItem.Text = "Image Subtraction";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 343);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(458, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(353, 343);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            pictureBox3.Location = new Point(882, 52);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(353, 343);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 409);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 4;
            label1.Text = "Image A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(605, 409);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 5;
            label2.Text = "Image B";
            // 
            // btnLoadImage
            // 
            btnLoadImage.Location = new Point(131, 471);
            btnLoadImage.Name = "btnLoadImage";
            btnLoadImage.Size = new Size(120, 30);
            btnLoadImage.TabIndex = 6;
            btnLoadImage.Text = "Load Image B";
            // 
            // btnLoadBackground
            // 
            btnLoadBackground.Location = new Point(560, 471);
            btnLoadBackground.Name = "btnLoadBackground";
            btnLoadBackground.Size = new Size(140, 30);
            btnLoadBackground.TabIndex = 7;
            btnLoadBackground.Text = "Load Background A";
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(1004, 471);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(100, 30);
            btnSubtract.TabIndex = 8;
            btnSubtract.Text = "Subtract";
            // 
            // Form1
            // 
            ClientSize = new Size(1550, 600);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnLoadImage);
            Controls.Add(btnLoadBackground);
            Controls.Add(btnSubtract);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Digital Image Processor";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
    }
}
