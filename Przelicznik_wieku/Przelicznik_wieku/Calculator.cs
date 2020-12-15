using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Przelicznik_wieku
{
    class Calculator
    {
        public static int CalculateDays(string yeartext, string monthtext, string daytext, string hourtext)
        {
            //Z godziną muszę ogarnąć no i zastanowić się co zrobić jak podadzą obecny dzień
            DateTime current = DateTime.Now;
            String BirthDateString = yeartext + '-' + monthtext + '-' + daytext + '-' + hourtext;
            DateTime BirthDate = DateTime.Parse(BirthDateString);
            TimeSpan elapsed = current.Subtract(BirthDate);
            double daysAgo = elapsed.TotalDays;
            return Convert.ToInt32(daysAgo);
        }
        public static int BigInteger(string yeartext, string monthtext, string daytext, string hourtext)
        {
            //Cóż to jeszcze do napisania
            return 0;
        }
    }
}
