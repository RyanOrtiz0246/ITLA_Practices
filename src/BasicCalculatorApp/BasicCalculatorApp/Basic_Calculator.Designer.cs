namespace BasicCalculatorApp
{
    partial class Basic_Calculator
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
            textNumber1 = new TextBox();
            textNumber2 = new TextBox();
            btnAddition = new Button();
            btnSubtration = new Button();
            btnClean = new Button();
            listBoxResult = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textNumber1
            // 
            textNumber1.Location = new Point(109, 40);
            textNumber1.Name = "textNumber1";
            textNumber1.Size = new Size(150, 31);
            textNumber1.TabIndex = 0;
            // 
            // textNumber2
            // 
            textNumber2.Location = new Point(317, 40);
            textNumber2.Name = "textNumber2";
            textNumber2.Size = new Size(150, 31);
            textNumber2.TabIndex = 1;
            // 
            // btnAddition
            // 
            btnAddition.Location = new Point(91, 94);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(112, 34);
            btnAddition.TabIndex = 2;
            btnAddition.Text = "Addition";
            btnAddition.UseVisualStyleBackColor = true;
            btnAddition.Click += btnAddition_Click;
            // 
            // btnSubtration
            // 
            btnSubtration.Location = new Point(229, 94);
            btnSubtration.Name = "btnSubtration";
            btnSubtration.Size = new Size(112, 34);
            btnSubtration.TabIndex = 3;
            btnSubtration.Text = "Subtraction";
            btnSubtration.UseVisualStyleBackColor = true;
            btnSubtration.Click += btnSubtration_Click;
            // 
            // btnClean
            // 
            btnClean.Location = new Point(371, 94);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(112, 34);
            btnClean.TabIndex = 4;
            btnClean.Text = "Clean";
            btnClean.UseVisualStyleBackColor = true;
            btnClean.Click += btnClean_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 25;
            listBoxResult.Location = new Point(91, 201);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(392, 254);
            listBoxResult.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(91, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 61);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Basic_Calculator
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 467);
            Controls.Add(pictureBox1);
            Controls.Add(listBoxResult);
            Controls.Add(btnClean);
            Controls.Add(btnSubtration);
            Controls.Add(btnAddition);
            Controls.Add(textNumber2);
            Controls.Add(textNumber1);
            Name = "Basic_Calculator";
            Text = "Form1";
            Load += Basic_Calculator_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textNumber1;
        private TextBox textNumber2;
        private Button btnAddition;
        private Button btnSubtration;
        private Button btnClean;
        private ListBox listBoxResult;
        private PictureBox pictureBox1;
    }
}
