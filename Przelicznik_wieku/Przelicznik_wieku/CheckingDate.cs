using System;
using System.Collections.Generic;
using System.Text;

namespace Przelicznik_wieku
{
    class CheckingDate
    {
       public static string IsDateOkay(string yeartext, int month, string daytext, string hourtext, string monthtext)
        {
            //Sprawdza czy wszystkie argumenty zostały podane
            if(string.IsNullOrEmpty(yeartext) || string.IsNullOrEmpty(monthtext) || string.IsNullOrEmpty(daytext) || string.IsNullOrEmpty(hourtext))
            {
                return "You have lef one of the spots empty, please don't do that.";
            }
            var current = DateTime.Now;
            bool yearparse = int.TryParse(yeartext, out int year);
            bool dayparse = int.TryParse(daytext, out int day);
            bool hourparse = int.TryParse(hourtext, out int hour);
            //Sprawdza czy wszystkie argumenty są liczbami
            if(!yearparse || !dayparse || !hourparse)
            {
                return "You have entered wrog value, pleas enter only numbers.";
            }
            
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
