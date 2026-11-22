namespace lab03p01
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            hScrollBar1 = new HScrollBar();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(22, 23);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(174, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F);
            textBox2.Location = new Point(251, 23);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(174, 39);
            textBox2.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(22, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(174, 176);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waluta źródłowa";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(14, 130);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(83, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "EURO";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.MouseCaptureChanged += radioButton3_MouseCaptureChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(14, 85);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "USD";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Click += radioButton2_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(14, 40);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(68, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "PLN";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.MouseCaptureChanged += radioButton1_MouseCaptureChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton6);
            groupBox2.Controls.Add(radioButton5);
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Location = new Point(251, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(174, 176);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Walya docelowa";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(12, 130);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(83, 29);
            radioButton6.TabIndex = 2;
            radioButton6.Text = "EURO";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.MouseCaptureChanged += radioButton6_MouseCaptureChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(12, 85);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(72, 29);
            radioButton5.TabIndex = 1;
            radioButton5.Text = "USD";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.MouseCaptureChanged += radioButton5_MouseCaptureChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(12, 40);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 29);
            radioButton4.TabIndex = 0;
            radioButton4.Text = "PLN";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.MouseCaptureChanged += radioButton4_MouseCaptureChanged;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(24, 296);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(401, 39);
            hScrollBar1.TabIndex = 4;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 370);
            Controls.Add(hScrollBar1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Przelicznik walut";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private GroupBox groupBox2;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private HScrollBar hScrollBar1;
    }
}
