namespace lab03p01_graKolory
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(560, 54);
            label1.TabIndex = 0;
            label1.Text = "Punkty: 0";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Dock = DockStyle.Bottom;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(0, 625);
            button1.Name = "button1";
            button1.Size = new Size(560, 76);
            button1.TabIndex = 1;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.LightGray;
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(0, 533);
            label2.Name = "label2";
            label2.Size = new Size(560, 92);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Location = new Point(32, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 200);
            panel1.TabIndex = 3;
            panel1.MouseEnter += panel1_MouseEnter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lime;
            panel2.Location = new Point(331, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 200);
            panel2.TabIndex = 4;
            panel2.MouseEnter += panel2_MouseEnter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Blue;
            panel3.Location = new Point(32, 318);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 200);
            panel3.TabIndex = 5;
            panel3.MouseEnter += panel3_MouseEnter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Yellow;
            panel4.Location = new Point(331, 318);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 200);
            panel4.TabIndex = 6;
            panel4.MouseEnter += panel4_MouseEnter;
            // 
            // timer1
            // 
            timer1.Interval = 750;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 30000;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 701);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "GRA w kolory";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}
