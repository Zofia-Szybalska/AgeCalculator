using System;
using System.Collections.Generic;
using System.Text;

namespace Przelicznik_wieku
{
    class Calculator
    {
        public static int CalculateDays(string yeartext, string monthtext, string daytext, string hourtext)
        {
            DateTime current = DateTime.Now;
            String BirthDateString = yeartext + '-' + monthtext + '-' + daytext + '-' + hourtext;
            DateTime BirthDate = DateTime.Parse(BirthDateString);
            TimeSpan elapsed = current.Subtract(BirthDate);
            double daysAgo = elapsed.TotalDays;
            return Convert.ToInt32(daysAgo);
        }
    }
}
