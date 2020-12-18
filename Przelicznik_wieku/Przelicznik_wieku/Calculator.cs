using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Przelicznik_wieku
{
    class Calculator
    {
        public static int CalculateDays(DateTime BirthDate)
        {
            DateTime current = DateTime.Now;
            TimeSpan elapsed = current - BirthDate;
            int days = (int)elapsed.TotalDays;
            return days;
        }
        public static BigInteger CalculateSeconds(DateTime BirthDate)
        {
            DateTime current = DateTime.Now;
            TimeSpan interval= current - BirthDate;
            BigInteger seconds = (int)interval.TotalSeconds;
            return seconds;
        }
        public static DateTime GetDateTime(string yeartext, int month, string daytext, string hourtext)
        {
            string monthtext = month.ToString();
            String BirthDateString = yeartext + '-' + monthtext + '-' + daytext + '-' + hourtext;
            DateTime BirthDate;
            string[] hour = hourtext.Split(':');
            if (hour.Length == 2)
            {
                BirthDate = DateTime.ParseExact(BirthDateString, "yyyy-M-d-H:m", null);
            }
            else if (hour.Length == 1)
            {
                BirthDate = DateTime.ParseExact(BirthDateString, "yyyy-M-d-H", null);
            }
            else
            {
                BirthDate = DateTime.ParseExact(BirthDateString, "yyyy-M-d-H:m:s", null);
            }
            return BirthDate;
        }
    }
}
