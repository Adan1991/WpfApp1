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

namespace WpfApp1
{
    /// <summary>
    /// Probando a subir con comentario nuevo. 
    /// </summary>
    public partial class MainWindow : Window
    {

        enum operation
        {
            nothing,
            add,
            substract,
            multiply,
            divide
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private int storedValue = 0;
        private operation actualOperation;
        

        private void BtnNumber_Click(object sender, RoutedEventArgs e)
        {
            if (tbScreen.Text != "0") {
            tbScreen.Text += ((Button)sender).Content;
            }
            else { tbScreen.Text = ""+((Button)sender).Content; }
          
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (tbScreen.Text != "0")
            {
            tbScreen.Text += "0";
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            actualOperation = operation.add;
            storedValue = Convert.ToInt32(tbScreen.Text);
            tbScreen.Text = "0";
        }

        private void BtnC_Click(object sender, RoutedEventArgs e)
        {
            tbScreen.Text = "0";
            actualOperation = operation.nothing;
        }

        private void BtnSubstract_Click(object sender, RoutedEventArgs e)
        {
            actualOperation = operation.substract;
            storedValue = Convert.ToInt32(tbScreen.Text);
            tbScreen.Text = "0";
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            actualOperation = operation.multiply;
            storedValue = Convert.ToInt32(tbScreen.Text);
            tbScreen.Text = "0";
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            actualOperation = operation.divide;
            storedValue = Convert.ToInt32(tbScreen.Text);
            tbScreen.Text = "0";
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (actualOperation)
            {

                case operation.add:
                tbScreen.Text = (Convert.ToInt32(tbScreen.Text) + storedValue).ToString();
                break;
                case operation.substract:
                    tbScreen.Text = (storedValue  - Convert.ToInt32(tbScreen.Text)).ToString();
                    break;
                case operation.multiply:
                  tbScreen.Text = (Convert.ToInt32(tbScreen.Text) * storedValue).ToString();
                    break;
                case operation.divide:
                    tbScreen.Text = (storedValue  / Convert.ToInt32(tbScreen.Text)).ToString();
                    break;      
            }
            actualOperation = operation.nothing;

        }

        private void btn(object sender, RoutedEventArgs e)
        {

        }
    }
}
