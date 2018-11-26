using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LRU
{
    class Program
    {
        static void Main(string[] args)
        {
            LRUPageReplacement();
        }

        /*
        private static void GenerateList(int listLength, int[] list)
        {
            Random rnd = new Random();

            for (int i = 0; i < listLength; i++)
                list[i] = rnd.Next(8);
        }
        */

        private static void LRUPageReplacement()
        {
            int pageFrameLength = 4, pageFaults = 0, position, min, pos = pageFrameLength + 1;
            int[] list = new int[] { 7, 0, 1, 2, 0, 3, 0, 4, 2, 3, 0, 3, 2 };
            int[] pageFrame = new int[pageFrameLength];
            int[] pagePosition = new int[pageFrameLength];
            bool found;

            Console.WriteLine("Least Recently Used Page Replacement Algorithm");

            for (int i = 0; i < pageFrameLength; i++)
                pageFrame[i] = -1;

            for (int i = 0; i < pageFrameLength; i++)
                pagePosition[i] = i;

            Console.Write("List: ");

            foreach (int i in list)
                Console.Write(i + " ");

            Console.WriteLine();

            for (int i = 0; i < list.Length; i++)
            {
                found = false;
                min = pagePosition[0];
                position = 0;

                for (int j = 0; j < pageFrameLength; j++)
                {
                    if (pageFrame[j] == list[i])
                    {
                        found = true;
                        position = j;
                    }
                    else if (!found && pagePosition[j] < min)
                    {
                        min = pagePosition[j];
                        position = j;
                    }
                }

                if (!found)
                {
                    pageFrame[position] = list[i];
                    pageFaults++;
                }

                pagePosition[position] = pos;
                pos++;

                if (!found)
                    Console.WriteLine("\nPage fault: " + !found + " (" + list[i] + ")");
                else
                    Console.WriteLine("\nPage fault: " + !found);

                Console.Write("Page frame: ");

                foreach (int j in pageFrame)
                    Console.Write(j + " ");

                Console.Write("\nPosition:   ");

                foreach (int j in pagePosition)
                    Console.Write(j + " ");

                Console.WriteLine();
            }

            Console.WriteLine("\nPage faults: " + pageFaults);
        }
    }
}
