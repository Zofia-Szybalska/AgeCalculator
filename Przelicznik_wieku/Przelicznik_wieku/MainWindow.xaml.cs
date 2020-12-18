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
        //To może wyglądać inaczej, w sumie chciałam tylko sprawdzić czy te inne rzeczy dobrze działają
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var result = CheckingDate.IsDateOkay(YearText.Text, MonthText.SelectedIndex + 1, DayText.Text, HourText.Text, MonthText.Text);

            if (!string.IsNullOrEmpty(result) && !result.StartsWith('I'))
            {

                ResultTextBox.Text = result;
            }
            else
            {
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
