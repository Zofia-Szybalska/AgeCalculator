using System;
using System.Collections.Generic;
using System.Text;

namespace Przelicznik_wieku
{
    class CheckingDate
    {
       public static string IsDateOkay(string yeartext, string monthtext, string daytext, string hourtext)
        {
            var current = DateTime.Now;
            int year = int.Parse(yeartext);
            int month = int.Parse(monthtext);
            int day = int.Parse(daytext);
            int hour = int.Parse(hourtext);
            //Sprawdzanie czy data nie jest w przyszłośći
            if (year > current.Year || 
               (year == current.Year && month > current.Month) || 
               (year == current.Year && month == current.Month && day > current.Day) ||
               (year == current.Year && month == current.Month && day == current.Day && hour > current.Hour))
            {
                return "Jestem pewny na 10 milionów procent, że ta data jeszcze nie nastąpiła.";
                
            }
            //Sprawdzanie czy data nie jest zbyt odległa w czasie
            else if( year < (int)current.Year - 150)
            {
                return "Jestem pewny na 10 milionów procent, że wtedy nie było cię jeszcze na świecie.";
            }
            //Sprawdzanie czy w podanym miesiącu może być tyle dni
            if(DateTime.DaysInMonth(year, month) < day)
            {
                return "Jesten na 10 milionów procent pewnien, że ten miesiąc nie ma aż tylu dni.";
            }

            if (month == current.Month && day == current.Day)
            {
                return "O, z tego wynika, że na 10 milionów procent masz dzisiaj urodziny, wszystkiego najlepszego. ";
            }
                

            return null;
        }
    }
}
