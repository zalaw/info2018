using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, pa = 0, pb = 0;
            bool error;

            do
            {
                Console.Write("a = ");
                error = false;

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
                Console.Write("b = ");
                error = false;

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
                Console.Write("pa = ");
                error = false;

                try
                {
                    pa = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    error = true;
                }
            } while (error);

            do
            {
                Console.Write("pb = ");
                error = false;

                try
                {
                    pb = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    error = true;
                }
            } while (error);

            Console.WriteLine("Media aritmetica: " + (a + b) / 2);

            Console.WriteLine("Media geometrica: " + Math.Sqrt(a * b));

            Console.WriteLine("Media ponderata: " + (a * pa + b * pb) / (pa + pb));
        }
    }
}
