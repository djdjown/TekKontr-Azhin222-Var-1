using System;
using System.Windows;
using WpfApp1;

namespace ExamResultApp
{
    public partial class MainWindow : Window
    {
        private ExamCalculator _calculator;

        public MainWindow()
        {
            InitializeComponent();
            _calculator = new ExamCalculator(); 
        }

        private void CalculateResult(object sender, RoutedEventArgs e)
        {
            try
            {
                int task1 = int.Parse(Task1Score.Text);
                int task2 = int.Parse(Task2Score.Text);
                int task3 = int.Parse(Task3Score.Text);
                int task4 = int.Parse(Task4Score.Text);

             
                var result = _calculator.Calculate(task1, task2, task3, task4);

                if (!result)
                {
                    MessageBox.Show("Некорректные значения баллов. Проверьте введенные данные.");
                    return;
                }

                
                TotalScore.Text = _calculator.TotalScore.ToString();
                Grade.Text = _calculator.Grade;
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите числовые значения.");
            }
        }
    }
}
