using comboBox.Classes;
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
using System.Windows.Shapes;

namespace comboBox
{
    /// <summary>
    /// Interaction logic for programOne.xaml
    /// </summary>
    public partial class programOne : Window
    {
        public programOne()
        {
            InitializeComponent();
        }

        private void runProgram_Click(object sender, RoutedEventArgs e)
        {
            decimal balance = decimal.Parse(endingBalanceInput.Text);
            int checks = int.Parse(numberChecksInput.Text);
            BankCharges newAccount = new BankCharges(balance, checks);

            resultOutput.Content = newAccount.CalculateServiceFees();
        }
    }
}
