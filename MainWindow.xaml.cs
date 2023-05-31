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

namespace comboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string[] programs { set; get; }
        public MainWindow()
        {
            InitializeComponent();
            
            //each one of the following is a differente class of GUI
            programs = new string[] { "Bank Charges per Month", "Calculate Distance Traveled", "Calculate Shipping Charges","Test Scores Calculator"};

            //to bind the classes to the frontend
            DataContext = this;
        }

        private void select_Click(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex == 0)
            {
                programOne p1 = new programOne();
                this.Close(); // to shut down the main page
                p1.Show(); //if you just show, main window will be kept open, so to have only one window active at the same time
                //we should close the current window and then show the next window.
                
            }else if (comboBox.SelectedIndex == 1) //this is another way to call the program
            {
                programTwo p2 = new programTwo();
                this.Close();
                p2.Show();
            }
            else if (comboBox.SelectedIndex == 2) 
            {
                programThree p3 = new programThree();
                this.Close();
                p3.Show();
            }
            else if (comboBox.SelectedIndex == 3) 
            {
                programFour p4 = new programFour();
                this.Close();
                p4.Show();
            }

        }
    }
}
