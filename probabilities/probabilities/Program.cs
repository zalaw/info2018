using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probabilities
{
    class Program
    {
        static void Main(string[] args)
        {
            int goal = 250, games = 1000, win = 0;
            int money, coin;
            double result;

            Random rnd = new Random();

            for (int i = 0; i < games; i++)
            {
                money = 50;
                while (money != goal && money != 0)
                {
                    money--;
                    coin = rnd.Next(2);
                    if (coin == 1)
                        money += 2;  
                }
                if (money == goal)
                    win++;
            }

            result = (double)win * 100 / games;
            Console.WriteLine("Games: {0}, Wins: {1}\n{2}% to win", games, win, result);
        }
    }
}
