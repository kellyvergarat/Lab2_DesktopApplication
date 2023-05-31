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
    /// Interaction logic for programFour.xaml
    /// </summary>
    public partial class programFour : Window
    {
        public programFour()
        {
            InitializeComponent();
        }

        private void runProgram_Click(object sender, RoutedEventArgs e)
        {
            int testOne = int.Parse(gradeOneInput.Text);
            int testTwo = int.Parse(gradeTwoInput.Text);
            int testThree = int.Parse(gradeThreeInput.Text);
            
            TestScores ts = new TestScores(testOne,testTwo,testThree);
            averageOutput.Content = ts.CalculateAverage();
            letterOutput.Content = ts.GetLetterGrade();
        }


        //DSA, Array, ArrayList, LinkedLink, Time and Space (No Sorting probably in final) 
        //3 coding: 1 array, LinkedList, Stack   15

        // Collections - HT - Binary Tree - Observer - Review - Graphs - Decorator / MVC

        //Tip for interview: Hastable 2, binary tree 4 , array, OOp MAIN, sorting, LinkedList (#1)
    }
}
