using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comboBox.Classes
{
    class TestScores
    {
        private int testScore1;
        private int testScore2;
        private int testScore3;

        public TestScores(int score1, int score2, int score3)
        {
            this.testScore1 = score1;
            this.testScore2 = score2;
            this.testScore3 = score3;
        }

        public int GetTestScore1()
        {
            return testScore1;
        }

        public int GetTestScore2()
        {
            return testScore2;
        }

        public int GetTestScore3()
        {
            return testScore3;
        }

        public double CalculateAverage()
        {
            return (testScore1 + testScore2 + testScore3) / 3.0;
        }

        public string GetLetterGrade()
        {
            double average = CalculateAverage();
            string letterForGrade;
            switch ((int)average / 10)
            {
                case 10:
                case 9:
                    letterForGrade = "A";
                    break;
                case 8:
                    letterForGrade = "B";
                    break;
                case 7:
                    letterForGrade = "C";
                    break;
                case 6:
                    letterForGrade = "D";
                    break;
                default:
                    letterForGrade = "F";
                    break;
            }
            return letterForGrade;
        }
    }
}
