using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    public class ExamCalculator
    {
        public string Grade { get; private set; }
        public int TotalScore { get; private set; }


        public bool Calculate(int task1, int task2, int task3, int task4)
        {

            if (task1 < 0 || task1 > 10 || task2 < 0 || task2 > 50 || task3 < 0 || task3 > 30 || task4 < 0 || task4 > 10)
            {
                return false;
            }

            TotalScore = task1 + task2 + task3 + task4;


            if (TotalScore >= 70)
                Grade = "5";
            else if (TotalScore >= 40)
                Grade = "4";
            else if (TotalScore >= 20)
                Grade = "3";
            else
                Grade = "2";

            return true;
        }
    }
}
