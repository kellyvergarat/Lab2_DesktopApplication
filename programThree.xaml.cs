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
    /// Interaction logic for programThree.xaml
    /// </summary>
    public partial class programThree : Window
    {
        public programThree()
        {
            InitializeComponent();
        }

        private void runProgram_Click(object sender, RoutedEventArgs e)
        {
            double weight = double.Parse(weightInput.Text);
            double distance = double.Parse(distanceInput.Text);
            ShippingCharges sc = new ShippingCharges(weight);

            resultOutput.Content = sc.CalculateShippingCharges(distance);
        }
    }
}
