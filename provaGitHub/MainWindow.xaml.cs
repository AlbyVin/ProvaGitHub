using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace provaGitHub
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

        private void bottone1_Click(object sender, RoutedEventArgs e)
        {

            Somma somma = new Somma();

            double n1;
            double n2;
            double SOMMA;

            n1 = Convert.ToDouble(txtBox1.Text);
            n2 = Convert.ToDouble(txtBox2.Text);


            SOMMA = somma.calcoloSomma(n1, n2);

            risultato1.Content = SOMMA;

        }
    }
}
