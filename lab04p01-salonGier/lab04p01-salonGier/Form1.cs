namespace lab04p01_salonGier
{
    public partial class Form1 : Form
    {
        Color[] kolory = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.Purple };
        int liczba_1 = 0;
        int liczba_2 = 0;
        int liczba_3 = 0;
        const int PULA_STARTOWA = 100;
        int pula;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            pula = PULA_STARTOWA;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pula = PULA_STARTOWA;
            String s = "$ ";
            s += pula.ToString();
            s += " $";
            label1.Text = s;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            liczba_1 = random.Next(0, kolory.Length);
            liczba_2 = random.Next(0, kolory.Length);
            liczba_3 = random.Next(0, kolory.Length);
            panel1.BackColor = kolory[liczba_1];
            panel2.BackColor = kolory[liczba_2];
            panel3.BackColor = kolory[liczba_3];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
                timer1.Start();
                timer2.Stop();
          
        }
    }
}
