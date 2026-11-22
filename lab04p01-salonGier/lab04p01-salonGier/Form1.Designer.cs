namespace lab04p01_salonGier
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            button3 = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(40, 110);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 150);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(247, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 150);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Location = new Point(445, 110);
            panel3.Name = "panel3";
            panel3.Size = new Size(156, 150);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(656, 68);
            label1.TabIndex = 3;
            label1.Text = "$ 100 000 000 $";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(40, 291);
            button1.Name = "button1";
            button1.Size = new Size(561, 102);
            button1.TabIndex = 4;
            button1.Text = "STOP";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 150;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button2.Location = new Point(49, 411);
            button2.Name = "button2";
            button2.Size = new Size(354, 59);
            button2.TabIndex = 5;
            button2.Text = "Nowa gra";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(427, 411);
            button3.Name = "button3";
            button3.Size = new Size(174, 59);
            button3.TabIndex = 6;
            button3.Text = "Wypłać nagrodę";
            button3.UseVisualStyleBackColor = true;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 516);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Salon gier";
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timer2;
    }
}
