namespace ImageParalleling
{
    partial class ImageGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxGray = new PictureBox();
            pictureBoxMirror = new PictureBox();
            pictureBoxThresh = new PictureBox();
            pictureBoxNeg = new PictureBox();
            pictureBoxMain = new PictureBox();
            buttonParallel = new Button();
            buttonLoad = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMirror).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNeg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxGray
            // 
            pictureBoxGray.Location = new Point(719, 218);
            pictureBoxGray.Name = "pictureBoxGray";
            pictureBoxGray.Size = new Size(200, 200);
            pictureBoxGray.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGray.TabIndex = 13;
            pictureBoxGray.TabStop = false;
            // 
            // pictureBoxMirror
            // 
            pictureBoxMirror.Location = new Point(513, 218);
            pictureBoxMirror.Name = "pictureBoxMirror";
            pictureBoxMirror.Size = new Size(200, 200);
            pictureBoxMirror.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMirror.TabIndex = 12;
            pictureBoxMirror.TabStop = false;
            // 
            // pictureBoxThresh
            // 
            pictureBoxThresh.Location = new Point(719, 12);
            pictureBoxThresh.Name = "pictureBoxThresh";
            pictureBoxThresh.Size = new Size(200, 200);
            pictureBoxThresh.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxThresh.TabIndex = 11;
            pictureBoxThresh.TabStop = false;
            // 
            // pictureBoxNeg
            // 
            pictureBoxNeg.Location = new Point(513, 12);
            pictureBoxNeg.Name = "pictureBoxNeg";
            pictureBoxNeg.Size = new Size(200, 200);
            pictureBoxNeg.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNeg.TabIndex = 10;
            pictureBoxNeg.TabStop = false;
            // 
            // pictureBoxMain
            // 
            pictureBoxMain.Location = new Point(12, 12);
            pictureBoxMain.Name = "pictureBoxMain";
            pictureBoxMain.Size = new Size(415, 415);
            pictureBoxMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMain.TabIndex = 9;
            pictureBoxMain.TabStop = false;
            // 
            // buttonParallel
            // 
            buttonParallel.BackColor = SystemColors.Control;
            buttonParallel.Font = new Font("Footlight MT Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonParallel.Location = new Point(433, 218);
            buttonParallel.Name = "buttonParallel";
            buttonParallel.Size = new Size(74, 53);
            buttonParallel.TabIndex = 8;
            buttonParallel.Text = "Parallel Processing";
            buttonParallel.UseVisualStyleBackColor = false;
            buttonParallel.Click += buttonParallel_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.Control;
            buttonLoad.Font = new Font("Footlight MT Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLoad.Location = new Point(433, 159);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(74, 53);
            buttonLoad.TabIndex = 7;
            buttonLoad.Text = "Load Image";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            // 
            // ImageGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 450);
            Controls.Add(pictureBoxGray);
            Controls.Add(pictureBoxMirror);
            Controls.Add(pictureBoxThresh);
            Controls.Add(pictureBoxNeg);
            Controls.Add(pictureBoxMain);
            Controls.Add(buttonParallel);
            Controls.Add(buttonLoad);
            Name = "ImageGUI";
            Text = "Parallel image processing";
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMirror).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNeg).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxGray;
        private PictureBox pictureBoxMirror;
        private PictureBox pictureBoxThresh;
        private PictureBox pictureBoxNeg;
        private PictureBox pictureBoxMain;
        private Button buttonParallel;
        private Button buttonLoad;
        private OpenFileDialog openFileDialog1;
    }
}
