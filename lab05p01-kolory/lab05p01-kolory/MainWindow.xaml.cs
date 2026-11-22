using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab05p01_kolory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void suwakR_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelR.Content = Math.Round(suwakR.Value).ToString();
            Color kolor = Color.FromRgb((byte)e.NewValue, 0, 0);
            Brush pedzel = new SolidColorBrush(kolor);
            p1.Fill = pedzel;
            kolor_probnika();
        }



        private void suwakG_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelG.Content = Math.Round(suwakG.Value).ToString();
            Color kolor = Color.FromRgb(0, (byte)e.NewValue, 0);
            Brush pedzel = new SolidColorBrush(kolor);
            p2.Fill = pedzel;
            kolor_probnika();
        }

        private void suwakB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            labelB.Content = Math.Round(suwakB.Value).ToString();
            Color kolor = Color.FromRgb(0, 0, (byte)e.NewValue);
            Brush pedzel = new SolidColorBrush(kolor);
            p3.Fill = pedzel;

            kolor_probnika();
        }

        private void kolor_probnika()
        {
            if (suwakR == null || suwakG == null || suwakB == null || probnik == null || druk == null) return;
            Color k1;
            if (druk.IsChecked == false)
            {
                k1 = Color.FromRgb((Byte)suwakR.Value, (Byte)suwakG.Value, (Byte)suwakB.Value);
            }
            else
            {
                int szarosc = ((int)suwakR.Value + (int)suwakG.Value + (int)suwakB.Value) / 3;
                k1 = Color.FromRgb((Byte)szarosc, (Byte)szarosc, (Byte)szarosc);
            }

            int jasnosc= ((int)suwakR.Value + (int)suwakG.Value + (int)suwakB.Value) / 3;
            if(jasnosc <128)
            {
                druk.Foreground = new SolidColorBrush(Colors.White);
            }
            else
            {
                druk.Foreground = new SolidColorBrush(Colors.Black);
            }
            probnik.Fill = new SolidColorBrush(k1);
        }

        private void druk_Checked(object sender, RoutedEventArgs e)
        {
            kolor_probnika();
        }
    }
}