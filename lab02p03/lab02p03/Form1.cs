namespace lab02p03
{
    public partial class Form1 : Form
    {

        int a = 10;
        int b = 10;
        public Form1()
        {
            InitializeComponent();
            hScrollBar1.Value = a;
            hScrollBar2.Value = b;
            label2.Text = a.ToString();
            label4.Text = b.ToString();
            oblicz();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            a = hScrollBar1.Value;
            label2.Text = a.ToString();
            oblicz();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            b = hScrollBar2.Value;
            label4.Text = b.ToString();
            oblicz();
        }

        private void oblicz()
        {
            label6.Text = (a * b).ToString();
            label8.Text = (a + b).ToString();
        }
    }
}
