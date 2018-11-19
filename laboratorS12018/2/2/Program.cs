using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f, a, b;

            Random rnd = new Random();

            a = rnd.Next(255);
            b = rnd.Next(255);
            f = a * 1.8 + 32;
            c = (b - 32) / 1.8;

            Console.WriteLine("{0} grade Celsius = {1} grade Fahrenheit", a, f);
            Console.WriteLine("{0} grade Fahrenehit = {1} grade Celsius", b, c);
        }
    }
}
