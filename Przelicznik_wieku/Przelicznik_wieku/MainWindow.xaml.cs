using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

namespace Przelicznik_wieku
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var result = CheckingDate.IsDateOkay(YearText.Text, MonthText.SelectedIndex + 1, DayText.Text, HourText.Text, MonthText.Text);

            if (!string.IsNullOrEmpty(result) && !result.StartsWith('I'))
            {

                ResultTextBox.Foreground = Brushes.Red;
                ResultTextBox.Text = result;
            }
            else
            {
                ResultTextBox.Foreground = Brushes.White;
                var BirthDate = Calculator.GetDateTime(YearText.Text, MonthText.SelectedIndex + 1, DayText.Text, HourText.Text);
                var days = Calculator.CalculateDays(BirthDate);
                var seconds = Calculator.CalculateSeconds(BirthDate);
                if (!string.IsNullOrEmpty(result))
                {
                    ResultTextBox.Text = result + $"\nYou were born { seconds } seconds ago which is { days } days.";
                }
                else
                {
                    ResultTextBox.Text = $"You were born { seconds } seconds ago which is { days } days.";
                }
            }
            


        }
        
    }
}
