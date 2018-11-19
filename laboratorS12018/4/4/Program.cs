using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
            double p, s;
            bool error;

            do
            {
                error = false;
                Console.Write("a = ");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    error = true;
                }
            } while (error);

            do
            {
                error = false;
                Console.Write("b = ");
                try
                {
                    b = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    error = true;
                }
            } while (error);

            do
            {
                error = false;
                Console.Write("c = ");
                try
                {
                    c = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    error = true;
                }
            } while (error);

            p = (double)((a + b + c) / 2);
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine("Aria triunghiului este " + s);
        }
    }
}
