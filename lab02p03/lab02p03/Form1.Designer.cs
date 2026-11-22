namespace lab02p03
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            hScrollBar1 = new HScrollBar();
            hScrollBar2 = new HScrollBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(58, 45);
            label1.TabIndex = 0;
            label1.Text = "a=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(76, 9);
            label2.Name = "label2";
            label2.Size = new Size(105, 45);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(12, 54);
            label3.Name = "label3";
            label3.Size = new Size(61, 45);
            label3.TabIndex = 2;
            label3.Text = "b=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(76, 54);
            label4.Name = "label4";
            label4.Size = new Size(105, 45);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(49, 152);
            label5.Name = "label5";
            label5.Size = new Size(112, 45);
            label5.TabIndex = 4;
            label5.Text = "Pole =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(167, 152);
            label6.Name = "label6";
            label6.Size = new Size(105, 45);
            label6.TabIndex = 5;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F);
            label7.Location = new Point(449, 152);
            label7.Name = "label7";
            label7.Size = new Size(155, 45);
            label7.TabIndex = 6;
            label7.Text = "Obwód =";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F);
            label8.Location = new Point(610, 152);
            label8.Name = "label8";
            label8.Size = new Size(105, 45);
            label8.TabIndex = 7;
            label8.Text = "label8";
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new Point(215, 15);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(564, 39);
            hScrollBar1.TabIndex = 8;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // hScrollBar2
            // 
            hScrollBar2.LargeChange = 1;
            hScrollBar2.Location = new Point(215, 60);
            hScrollBar2.Name = "hScrollBar2";
            hScrollBar2.Size = new Size(564, 39);
            hScrollBar2.TabIndex = 9;
            hScrollBar2.Scroll += hScrollBar2_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 243);
            Controls.Add(hScrollBar2);
            Controls.Add(hScrollBar1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private HScrollBar hScrollBar1;
        private HScrollBar hScrollBar2;
    }
}
