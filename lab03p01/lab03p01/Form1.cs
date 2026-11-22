namespace lab03p01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double przelicz(double kwota, int w1, int w2)
        // w1 - waluta z której przeliczamy
        // w2 -waluta na ktora przeliczmy
        // 1 - PLN, 2 - USD, 3 - EUR
        {
            double kwota_przeliczeniowa = 0;
            switch(w1)
            {
                case 1:
                    kwota_przeliczeniowa = kwota;
                    break;
                case 2:
                    kwota_przeliczeniowa = kwota * 3.9;
                    break;
                case 3:
                    kwota_przeliczeniowa = kwota * 4.2;
                    break;
            }
            double kwota_wynikowa = 0;
            switch(w2)
            {
                case 1:
                    kwota_wynikowa = kwota_przeliczeniowa;
                    break;
                case 2:
                    kwota_wynikowa = kwota_przeliczeniowa / 3.9;
                    break;
                case 3:
                    kwota_wynikowa = kwota_przeliczeniowa / 4.2;
                    break;
            }
            return kwota_wynikowa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kwota = 0;
            if (!int.TryParse(textBox1.Text, out kwota))
            {
                MessageBox.Show("Niepoprawna kwota");
                textBox1.Text = "";
                textBox1.Focus();
                return;
            }

            int w1 = 0;
            int w2 = 0;
            if (radioButton1.Checked)
                w1 = 1;
            else if(radioButton2.Checked)
                w1 = 2;
            else if(radioButton3.Checked)
                w1 = 3;
            
            if (radioButton4.Checked)
                w2 = 1;
            else if (radioButton5.Checked)
                w2 = 2;
            else if (radioButton6.Checked)
                w2 = 3;
            if(w1 == 0 || w2 == 0)
            {
                MessageBox.Show("Nie wybrano waluty");
                return;
            }
            double wynik = Math.Round(przelicz(kwota, w1, w2), 2);
            textBox2.Text = wynik.ToString();

        }
    }
}
