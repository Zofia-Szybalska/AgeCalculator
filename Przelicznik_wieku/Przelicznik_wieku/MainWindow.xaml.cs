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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var result = CheckingDate.IsDateOkay(YearText.Text, MonthText.Text, DayText.Text, HourText.Text);
            
            if (!string.IsNullOrEmpty(result) && !result.StartsWith('O'))
            {

                ResultTextBox.Text = result;
            }
            else
            {
                int days = Calculator.CalculateDays(YearText.Text, MonthText.Text, DayText.Text, HourText.Text);

                ResultTextBox.Text = result + $"\nYou were born { days } days ago { days * 24 * 3600}";
            }
            
           
        }
    }
}
