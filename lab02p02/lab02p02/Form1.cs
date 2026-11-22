namespace lab02p02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bezpieczne_dodawanie();
        }

        private void dodawanie()
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c = a + b;
            label3.Text = c.ToString();
        }

        private void bezpieczne_dodawanie()
        {
            int a = 0;
            int b = 0;
            if(!int.TryParse(textBox1.Text, out a))
            {
                textBox1.Text = "";
                MessageBox.Show("Niepoprawna wartość w polu A");
                return;
            }
            if (!int.TryParse(textBox2.Text, out b))
            {
                textBox2.Text = "";
                MessageBox.Show("Niepoprawna wartość w polu B");
                return;
            }
            int c = a + b;
            label3.Text = c.ToString();
        }
    }
}
