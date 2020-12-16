using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Przelicznik_wieku
{
    class Calculator
    {
        public static int CalculateDays(string yeartext, int month, string daytext, string hourtext)
        {
            //Z godziną muszę ogarnąć no i zastanowić się co zrobić z licznikiem dni jak podadzą obecny dzień
            DateTime current = DateTime.Now;
            string monthtext = month.ToString();
            String BirthDateString = yeartext + '-' + monthtext + '-' + daytext + '-' + hourtext;
            DateTime BirthDate;
            try
            {
                BirthDate = DateTime.ParseExact(BirthDateString, "yyyy-M-d-H:m", null);
            }
            catch (FormatException)
            {
                BirthDate = DateTime.ParseExact(BirthDateString, "yyyy-M-d-H", null);
            }
            TimeSpan elapsed = current.Subtract(BirthDate);
            double daysAgo = elapsed.TotalDays;
            return Convert.ToInt32(daysAgo);
        }
        public static int BigInteger(string yeartext, int month, string daytext, string hourtext)
        {
            //Cóż to jeszcze do napisania
            return 0;
        }
    }
}
