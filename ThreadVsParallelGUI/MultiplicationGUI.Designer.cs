namespace ThreadVsParallelGUI
{
    partial class MultiplicationGUI
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
            textBoxThreads = new TextBox();
            labelThread = new Label();
            textBoxSize = new TextBox();
            labelSize = new Label();
            buttonThread = new Button();
            buttonParallel = new Button();
            buttonVS = new Button();
            textBoxThTime = new TextBox();
            labelThTime = new Label();
            labelPaTime = new Label();
            textBoxPaTime = new TextBox();
            textBoxMatrix1 = new TextBox();
            textBoxMatrix2 = new TextBox();
            textBoxThResult = new TextBox();
            textBoxPaResult = new TextBox();
            labelThResult = new Label();
            labelPaResult = new Label();
            labelMatrix1 = new Label();
            labelMatrix2 = new Label();
            SuspendLayout();
            // 
            // textBoxThreads
            // 
            textBoxThreads.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxThreads.Location = new Point(27, 42);
            textBoxThreads.Name = "textBoxThreads";
            textBoxThreads.Size = new Size(100, 24);
            textBoxThreads.TabIndex = 0;
            // 
            // labelThread
            // 
            labelThread.AutoSize = true;
            labelThread.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelThread.Location = new Point(12, 21);
            labelThread.Name = "labelThread";
            labelThread.Size = new Size(136, 18);
            labelThread.TabIndex = 1;
            labelThread.Text = "Number of threads:";
            // 
            // textBoxSize
            // 
            textBoxSize.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxSize.Location = new Point(27, 90);
            textBoxSize.Name = "textBoxSize";
            textBoxSize.Size = new Size(100, 24);
            textBoxSize.TabIndex = 2;
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSize.Location = new Point(12, 69);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(140, 18);
            labelSize.TabIndex = 3;
            labelSize.Text = "Size of the matrixes:";
            // 
            // buttonThread
            // 
            buttonThread.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonThread.Location = new Point(17, 148);
            buttonThread.Name = "buttonThread";
            buttonThread.Size = new Size(125, 43);
            buttonThread.TabIndex = 7;
            buttonThread.Text = "Run Thread";
            buttonThread.UseVisualStyleBackColor = true;
            buttonThread.Click += buttonThread_Click;
            // 
            // buttonParallel
            // 
            buttonParallel.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonParallel.Location = new Point(17, 208);
            buttonParallel.Name = "buttonParallel";
            buttonParallel.Size = new Size(125, 43);
            buttonParallel.TabIndex = 8;
            buttonParallel.Text = "Run Parallel";
            buttonParallel.UseVisualStyleBackColor = true;
            buttonParallel.Click += buttonParallel_Click;
            // 
            // buttonVS
            // 
            buttonVS.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVS.Location = new Point(17, 268);
            buttonVS.Name = "buttonVS";
            buttonVS.Size = new Size(125, 43);
            buttonVS.TabIndex = 9;
            buttonVS.Text = "Run Both";
            buttonVS.UseVisualStyleBackColor = true;
            buttonVS.Click += buttonVS_Click;
            // 
            // textBoxThTime
            // 
            textBoxThTime.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxThTime.Location = new Point(27, 350);
            textBoxThTime.Name = "textBoxThTime";
            textBoxThTime.ReadOnly = true;
            textBoxThTime.Size = new Size(100, 24);
            textBoxThTime.TabIndex = 10;
            // 
            // labelThTime
            // 
            labelThTime.AutoSize = true;
            labelThTime.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelThTime.Location = new Point(4, 329);
            labelThTime.Name = "labelThTime";
            labelThTime.Size = new Size(159, 18);
            labelThTime.TabIndex = 11;
            labelThTime.Text = "Thread time execution:";
            // 
            // labelPaTime
            // 
            labelPaTime.AutoSize = true;
            labelPaTime.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaTime.Location = new Point(4, 377);
            labelPaTime.Name = "labelPaTime";
            labelPaTime.Size = new Size(162, 18);
            labelPaTime.TabIndex = 13;
            labelPaTime.Text = "Parallel time execution:";
            // 
            // textBoxPaTime
            // 
            textBoxPaTime.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPaTime.Location = new Point(27, 398);
            textBoxPaTime.Name = "textBoxPaTime";
            textBoxPaTime.ReadOnly = true;
            textBoxPaTime.Size = new Size(100, 24);
            textBoxPaTime.TabIndex = 12;
            // 
            // textBoxMatrix1
            // 
            textBoxMatrix1.Font = new Font("Footlight MT Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMatrix1.Location = new Point(169, 24);
            textBoxMatrix1.Multiline = true;
            textBoxMatrix1.Name = "textBoxMatrix1";
            textBoxMatrix1.ReadOnly = true;
            textBoxMatrix1.ScrollBars = ScrollBars.Both;
            textBoxMatrix1.Size = new Size(619, 121);
            textBoxMatrix1.TabIndex = 14;
            textBoxMatrix1.WordWrap = false;
            // 
            // textBoxMatrix2
            // 
            textBoxMatrix2.Font = new Font("Footlight MT Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxMatrix2.Location = new Point(169, 169);
            textBoxMatrix2.Multiline = true;
            textBoxMatrix2.Name = "textBoxMatrix2";
            textBoxMatrix2.ReadOnly = true;
            textBoxMatrix2.ScrollBars = ScrollBars.Both;
            textBoxMatrix2.Size = new Size(619, 121);
            textBoxMatrix2.TabIndex = 15;
            textBoxMatrix2.WordWrap = false;
            // 
            // textBoxThResult
            // 
            textBoxThResult.Font = new Font("Footlight MT Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxThResult.Location = new Point(166, 317);
            textBoxThResult.Multiline = true;
            textBoxThResult.Name = "textBoxThResult";
            textBoxThResult.ReadOnly = true;
            textBoxThResult.ScrollBars = ScrollBars.Both;
            textBoxThResult.Size = new Size(308, 121);
            textBoxThResult.TabIndex = 16;
            textBoxThResult.WordWrap = false;
            // 
            // textBoxPaResult
            // 
            textBoxPaResult.Font = new Font("Footlight MT Light", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPaResult.Location = new Point(480, 317);
            textBoxPaResult.Multiline = true;
            textBoxPaResult.Name = "textBoxPaResult";
            textBoxPaResult.ReadOnly = true;
            textBoxPaResult.ScrollBars = ScrollBars.Both;
            textBoxPaResult.Size = new Size(308, 121);
            textBoxPaResult.TabIndex = 17;
            textBoxPaResult.WordWrap = false;
            // 
            // labelThResult
            // 
            labelThResult.AutoSize = true;
            labelThResult.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelThResult.Location = new Point(270, 296);
            labelThResult.Name = "labelThResult";
            labelThResult.Size = new Size(99, 18);
            labelThResult.TabIndex = 18;
            labelThResult.Text = "Thread result:";
            // 
            // labelPaResult
            // 
            labelPaResult.AutoSize = true;
            labelPaResult.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPaResult.Location = new Point(589, 296);
            labelPaResult.Name = "labelPaResult";
            labelPaResult.Size = new Size(102, 18);
            labelPaResult.TabIndex = 19;
            labelPaResult.Text = "Parallel result:";
            // 
            // labelMatrix1
            // 
            labelMatrix1.AutoSize = true;
            labelMatrix1.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMatrix1.Location = new Point(166, 3);
            labelMatrix1.Name = "labelMatrix1";
            labelMatrix1.Size = new Size(89, 18);
            labelMatrix1.TabIndex = 20;
            labelMatrix1.Text = "First Matrix:";
            // 
            // labelMatrix2
            // 
            labelMatrix2.AutoSize = true;
            labelMatrix2.Font = new Font("Footlight MT Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMatrix2.Location = new Point(169, 148);
            labelMatrix2.Name = "labelMatrix2";
            labelMatrix2.Size = new Size(107, 18);
            labelMatrix2.TabIndex = 21;
            labelMatrix2.Text = "Second Matrix:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelMatrix2);
            Controls.Add(labelMatrix1);
            Controls.Add(labelPaResult);
            Controls.Add(labelThResult);
            Controls.Add(textBoxPaResult);
            Controls.Add(textBoxThResult);
            Controls.Add(textBoxMatrix2);
            Controls.Add(textBoxMatrix1);
            Controls.Add(labelPaTime);
            Controls.Add(textBoxPaTime);
            Controls.Add(labelThTime);
            Controls.Add(textBoxThTime);
            Controls.Add(buttonVS);
            Controls.Add(buttonParallel);
            Controls.Add(buttonThread);
            Controls.Add(labelSize);
            Controls.Add(textBoxSize);
            Controls.Add(labelThread);
            Controls.Add(textBoxThreads);
            Name = "Form1";
            Text = "Matrix multiplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxThreads;
        private Label labelThread;
        private TextBox textBoxSize;
        private Label labelSize;
        private Button buttonThread;
        private Button buttonParallel;
        private Button buttonVS;
        private TextBox textBoxThTime;
        private Label labelThTime;
        private Label labelPaTime;
        private TextBox textBoxPaTime;
        private TextBox textBoxMatrix1;
        private TextBox textBoxMatrix2;
        private TextBox textBoxThResult;
        private TextBox textBoxPaResult;
        private Label labelThResult;
        private Label labelPaResult;
        private Label labelMatrix1;
        private Label labelMatrix2;
    }
}
