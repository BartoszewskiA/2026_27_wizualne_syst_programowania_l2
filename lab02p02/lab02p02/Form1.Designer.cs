namespace lab02p02
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F);
            textBox1.Location = new Point(12, 13);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 55);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 18F);
            textBox2.Location = new Point(219, 10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 55);
            textBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(168, 13);
            label1.Name = "label1";
            label1.Size = new Size(45, 48);
            label1.TabIndex = 2;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(384, 13);
            label2.Name = "label2";
            label2.Size = new Size(45, 48);
            label2.TabIndex = 3;
            label2.Text = "=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.Location = new Point(435, 13);
            label3.Name = "label3";
            label3.Size = new Size(39, 48);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(612, 12);
            button1.Name = "button1";
            button1.Size = new Size(176, 56);
            button1.TabIndex = 5;
            button1.Text = "LICZ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 85);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "DODAWACZ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
