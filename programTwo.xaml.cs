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
    /// Interaction logic for programTwo.xaml
    /// </summary>
    public partial class programTwo : Window
    {
        public programTwo()
        {
            InitializeComponent();
        }

        private void runProgram_Click(object sender, RoutedEventArgs e)
        {
            int speed = int.Parse(speedInput.Text);
            int distance = int.Parse(timeInput.Text);
            DistanceTraveled newDistance = new DistanceTraveled(speed, distance);

            resultOutput.Content = newDistance.GetDistance();
        }
    }
}
