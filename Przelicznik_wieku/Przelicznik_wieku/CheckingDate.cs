using System;
using System.Collections.Generic;
using System.Text;

namespace Przelicznik_wieku
{
    class CheckingDate
    {
       public static string IsDateOkay(string yeartext, int month, string daytext, string hourtext, string monthtext)
        {
            var current = DateTime.Now;
            int year = int.Parse(yeartext);
            int day = int.Parse(daytext);
            int hour = int.Parse(hourtext);
            //Sprawdzanie czy data nie jest w przyszłości
            if (year > current.Year || 
               (year == current.Year && month > current.Month) || 
               (year == current.Year && month == current.Month && day > current.Day) ||
               (year == current.Year && month == current.Month && day == current.Day && hour > current.Hour))
            {
                return "You couldn't have been born in the future, could you?";
                
            }
            //Sprawdzanie czy data nie jest zbyt odległa w czasie
            else if( year < (int)current.Year - 150)
            {
                return "You surely have not been born so long ago.";
            }
            //Sprawdzanie czy w podanym miesiącu może być tyle dni
            if(DateTime.DaysInMonth(year, month) < day)
            {
                return monthtext + " dose not have so many days.";
            }

            if (month == current.Month && day == current.Day)
            {
                return "It seems that you have birthday today, happy birthday!";
            }
                

            return null;
        }
    }
}
