namespace lab04p02
{
    partial class Form1
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            progressBar2 = new ProgressBar();
            progressBar3 = new ProgressBar();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(155, 60);
            progressBar1.MarqueeAnimationSpeed = 1;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(342, 34);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(27, 64);
            label1.Name = "label1";
            label1.Size = new Size(27, 32);
            label1.TabIndex = 1;
            label1.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(27, 113);
            label2.Name = "label2";
            label2.Size = new Size(27, 32);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(27, 166);
            label3.Name = "label3";
            label3.Size = new Size(27, 32);
            label3.TabIndex = 3;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(101, 64);
            label4.Name = "label4";
            label4.Size = new Size(29, 32);
            label4.TabIndex = 4;
            label4.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(101, 113);
            label5.Name = "label5";
            label5.Size = new Size(27, 32);
            label5.TabIndex = 5;
            label5.Text = "S";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(97, 166);
            label6.Name = "label6";
            label6.Size = new Size(31, 32);
            label6.TabIndex = 6;
            label6.Text = "D";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(512, 62);
            label7.Name = "label7";
            label7.Size = new Size(32, 32);
            label7.TabIndex = 7;
            label7.Text = "Q";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(512, 113);
            label8.Name = "label8";
            label8.Size = new Size(36, 32);
            label8.TabIndex = 8;
            label8.Text = "W";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(512, 164);
            label9.Name = "label9";
            label9.Size = new Size(26, 32);
            label9.TabIndex = 9;
            label9.Text = "E";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(155, 113);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(342, 34);
            progressBar2.TabIndex = 10;
            // 
            // progressBar3
            // 
            progressBar3.Location = new Point(155, 164);
            progressBar3.Name = "progressBar3";
            progressBar3.Size = new Size(342, 34);
            progressBar3.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 262);
            Controls.Add(progressBar3);
            Controls.Add(progressBar2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ProgressBar progressBar2;
        private ProgressBar progressBar3;
    }
}
