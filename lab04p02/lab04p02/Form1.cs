namespace lab04p02
{
    public partial class Form1 : Form
    {

        int x = 0;
        int y = 0;
        int z = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //label1.Text = e.KeyChar.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            char znak = (char)e.KeyValue;
            switch(znak)
            {
                case 'Q':
                    x++;
                    break;
                case 'W':
                    y++;
                    break;
                case 'E':
                    z++;
                    break;
                    case 'A':
                    x--;
                    break;
                case 'S':
                    y--;
                    break;
                case 'D':
                    z--;
                    break;
            }
            if(x >=0 && x<=100)
            {
                progressBar1.Value = x;
            }
            if(y >=0 && y<=100)
            {
                progressBar2.Value = y;
            }
            if(z >=0 && z<=100)
            {
                progressBar3.Value = z;
            }

        }
    }
}
