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
            
            if (!string.IsNullOrEmpty(result))
            {
               
                MessageBox.Show(result);
            }
            else
            {
                DateTime current = DateTime.Now;
                String BirthDateString = $"{ DayText.Text }-{ MonthText.Text }-{ YearText.Text }-{ HourText.Text}";
                DateTime BirthDate = DateTime.Parse(BirthDateString);
                TimeSpan elapsed = current.Subtract(BirthDate);
                double daysAgo = elapsed.TotalDays;
                int days = Convert.ToInt32(daysAgo); 
                MessageBox.Show($"You were born {daysAgo.ToString("0") } days ago { days * 24 * 3600}");
            }
           
        }
    }
}
