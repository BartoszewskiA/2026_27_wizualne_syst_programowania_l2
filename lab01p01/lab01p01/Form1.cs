namespace lab01p01
{
    public partial class Form1 : Form
    {

        int licznik = 0;
        public Form1()
        {
            InitializeComponent();
            label1.ForeColor = Color.Blue;
        }

        private void wyswietlanie()
        {
            label1.Text = licznik.ToString();
            if (licznik > 0)
            {
                label1.ForeColor = Color.Green;
            }
            else if (licznik < 0)
            {
                label1.ForeColor = Color.Red;
            }
            else
            {
                label1.ForeColor = Color.Blue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            licznik++;
            wyswietlanie();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            licznik--;
           wyswietlanie();
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            licznik = 0;
           wyswietlanie();
        }
    }
}
