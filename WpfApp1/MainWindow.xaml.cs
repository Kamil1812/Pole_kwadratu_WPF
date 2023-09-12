using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("([0-9]{1,})");

            if (Bok.Text != "" && regex.IsMatch(Bok.Text))
            {
                int a = Int32.Parse(Bok.Text);
                int P = a * a;

                Wynik.Content = "Pole kwadratu o boku " + a + " wynosi: " + P;
            }

            else
            {
                MessageBox.Show("Wpisz poprawne dane", "Komunikat", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
