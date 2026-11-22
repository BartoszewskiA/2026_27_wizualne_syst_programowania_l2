namespace lab03p01_graKolory
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        String[] tabNazw = { "Czerwony", "Zielony", "Niebieski", "Żółty" };
        Color[] tabKolorow = { Color.Red, Color.Green, Color.Blue, Color.Yellow };
        int wylosowanyKolor = -1;
        int wylosowanaNazwa = -1;
        int licznikTrafień = 0;

        public Form1()
        {
            InitializeComponent();
            label2.Text = "Rozpocznij grę";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            wylosowanaNazwa = random.Next(0, tabNazw.Length);
            wylosowanyKolor = random.Next(0, tabKolorow.Length);
            label2.Text = tabNazw[wylosowanaNazwa];
            label2.ForeColor = tabKolorow[wylosowanyKolor];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            if(timer1.Enabled == true)
                zaliczTrafienie(0);
        }


        private void zaliczTrafienie(int nr_panelu)
        {
            if (nr_panelu == wylosowanyKolor)
            {
                licznikTrafień++;
                label1.Text = "Punkty: " + licznikTrafień;
                if(timer1.Interval > 50)
                timer1.Interval = timer1.Interval - 10;
            }
            else
            {
                licznikTrafień--;
                label1.Text = "Punkty: " + licznikTrafień;
                timer1.Interval = timer1.Interval + 10;
            }
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                zaliczTrafienie(1);
        }

        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                zaliczTrafienie(2);
        }

        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            if (timer1.Enabled == true) 
                zaliczTrafienie(3);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Enabled = false;
        }
    }
}
