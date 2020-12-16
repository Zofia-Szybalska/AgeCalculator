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
                int days = Calculator.CalculateDays(YearText.Text, MonthText.SelectedIndex + 1, DayText.Text, HourText.Text);
                if (!string.IsNullOrEmpty(result))
                {
                    ResultTextBox.Text = result + $"\nYou were born { days } days ago with is { days * 24 * 3600} seconds.";
                }
                else
                {
                    ResultTextBox.Text = $"You were born { days } days ago with is { days * 24 * 3600} seconds.";
                }
            }
            


        }
        
    }
}
