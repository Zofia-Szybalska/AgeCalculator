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
            int hour = 0;
            bool hourparse = false;
            int[] hourextended= { 00,00};
            if (hourtext.Contains(':'))
            {
                string[] hourextendedtext;
                hourextendedtext = hourtext.Split(':');
                for (int i = 0; i < hourextendedtext.Length; i++)
                {
                    hourparse = int.TryParse(hourextendedtext[i], out hourextended[i]);
                }
            }
            else
            {
                hourparse = int.TryParse(hourtext, out hourextended[0]);
            }
            //Sprawdza czy wszystkie argumenty są liczbami
            if (!yearparse || !dayparse || !hourparse)
            {
                return "You have entered wrog value, pleas enter only numbers.";
            }
            //Sprawdza czy godzina nie jest za dużą liczbą
            if (hourextended[0]>23 || hourextended[0] <0 || hourextended[1] < 0 || hourextended[1] > 60 )
            {
                return "You have entered an hour that dose not exist, pleas enter proper hour (from 0:00 to 23:59).";
            }
            
            //Sprawdza czy data nie jest w przyszłości
            if (year > current.Year || 
               (year == current.Year && month > current.Month) || 
               (year == current.Year && month == current.Month && day > current.Day) ||
               (year == current.Year && month == current.Month && day == current.Day && hour > current.Hour))
            {
                return "You couldn't have been born in the future, could you?";
                
            }
            //Sprawdza czy data nie jest zbyt odległa w czasie
            else if( year < (int)current.Year - 150)
            {
                return "You surely have not been born so long ago.";
            }
            //Sprawdza czy w podanym miesiącu może być tyle dni
            if(DateTime.DaysInMonth(year, month) < day)
            {
                return monthtext + " dose not have so many days.";
            }
            //Sprawdza czy nie wypadają akurat urodziny
            if (month == current.Month && day == current.Day)
            {
                return "It seems that you have birthday today, happy birthday!";
            }
                

            return null;
        }
    }
}
