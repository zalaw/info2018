using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOne = 1, monthOne = 1, yearOne = 1990;
            int dayTwo = 1, monthTwo = 1, yearTwo = 2020;
            int leapYear = 0;
            int days = 0, aux = 0;

            // ************************************

            /*Console.Write("Enter day one: ");
            dayOne = int.Parse(Console.ReadLine());
            Console.Write("Enter month one: ");
            monthOne = int.Parse(Console.ReadLine());
            Console.Write("Enter year one: ");
            yearOne = int.Parse(Console.ReadLine());
            Console.Write("Enter day two: ");
            dayTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter month two: ");
            monthTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter year two: ");
            yearTwo = int.Parse(Console.ReadLine());*/

            // ************************************

            // Counting how many leap years are in between the dates
            for (int i = yearOne + 1; i < yearTwo; i++)
                if ((i % 4 == 0 && i % 100 != 0) || (i % 400 == 0))
                    leapYear++;

            days = 365 * (yearTwo - yearOne - 1) + leapYear;

            // Calculates all the days from December to monthOne + 1
            for (int i = 12; i > monthOne; i--)
                if (i == 2)
                    if ((yearOne % 4 == 0 && yearOne % 100 != 0) || (yearOne % 400 == 0))
                        aux += 29;
                    else
                        aux += 28;
                else if ((i % 2 == 1 && i < 8) || (i % 2 == 0 && i >= 8))
                    aux += 31;
                else if ((i % 2 == 0 && i < 8) || (i % 2 == 1 && i > 8))
                    aux += 30;

            if ((monthOne % 2 == 1 && monthOne < 8) || (monthOne % 2 == 0 && monthOne >= 8))
                aux = aux + (31 - dayOne);
            else if ((monthOne % 2 == 0 && monthOne < 8) || (monthOne % 2 == 1 && monthOne > 8))
                aux = aux + (30 - dayOne);

            days = days + aux;

            // Adding up the days from day one and month one to monthOne
            for (int i = 1; i < monthTwo; i++)
                if (i == 2)
                    days += 28;
                else if ((i % 2 == 1 && i < 8) || (i % 2 == 0 && i >= 8))
                    days += 31;
                else if ((i % 2 == 0 && i < 8) || (i % 2 == 1 && i > 8))
                    days += 30;

            // Check if monthTwo is greater than February and if it is in a leap year
            if ((monthTwo > 2) && (yearTwo % 4 == 0 && yearTwo % 100 != 0) || (yearTwo % 400 == 0))
                days++;

            days += dayTwo;

            Console.WriteLine(days);
        }
    }
}
