using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze
{
    class Program
    {
        static void Main(string[] args)
        {
            int _base = 0, _secondBase = 0, length;
            char[] pattern = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
                                          'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                                          'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                                          'U', 'V', 'W', 'X', 'Y', 'Z' };
            string input;
            bool error, isGood;

            do
            {
                Console.Write("Introduceti un numar natural reprezentand baza (2 - 36): ");
                error = false;

                try
                {
                    _base = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nValoarea introdusa nu este un numar natural.\n");
                    error = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nNumarul introdus depaseste valoarea maxima sau minima a lui Int32.\nIntroduceti alt numar natural.\n");
                }

                if (_base < 2 || _base > 36)
                    error = true;
            } while (error);

            do
            {
                Console.Write("Introduceti numarul in baza {0} (fara spatii inainte sau dupa numar): ", _base);
                input = "";
                isGood = true;
                input = Console.ReadLine();
                input = input.ToUpper();
                length = 0;

                for (int i = 0; i < input.Length; i++)
                    for (int j = 0; j < pattern.Length; j++)
                        if (input[i] == pattern[j])
                            length++;

                for (int i = 0; i < input.Length; i++)
                    for (int j = _base; j < pattern.Length; j++)
                        if (input[i] == pattern[j])
                            isGood = false;

                if (!isGood)
                {
                    Console.WriteLine("\nNumarul nu face parte din baza {0}\n", _base);
                    isGood = false;
                }
                else if (length != input.Length)
                {
                    isGood = false;
                    Console.WriteLine("\nValoarea introdusa nu este un numar sau este dar contine spatii!\n");
                }
            } while (!isGood);

            do
            {
                Console.Write("Introduceti baza in care vreti sa fie transformat numarul {0} (baza diferita de {1}): ", input, _base);
                error = false;

                try
                {
                    _secondBase = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nValoarea introdusa nu este un numar natural.\n");
                    error = true;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("\nNumarul introdus depaseste valoarea maxima sau minima a lui Int32.\nIntroduceti alt numar natural.\n");
                }

                if (_secondBase == _base || _secondBase < 2 || _secondBase > 36)
                    error = true;
            } while (error);

            if (_base != 10)
            {
                int power = 1;
                int number = 0;
                int value = 0;

                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] >= '0' && input[i] <= '9')
                        value = (int)input[i] - '0';
                    else if (input[i] >= 'A' && input[i] <= 'Z')
                        value = (int)input[i] - '7';

                    number = number + value * power;
                    power *= _base;
                }

                Console.WriteLine(number);

                if (_secondBase != 10)
                {
                    int x = number;
                    string placeholder = "";
                    string secondNumber = "";
                    int j = 0;
                    int val;
                    string val2 = "";
                    
                    while (x != 0)
                    {
                        val = x % _secondBase;

                        if (val > 9)
                        {
                            switch (val)
                            {
                                case 10:
                                    val2 = "A";
                                    break;
                                case 11:
                                    val2 = "B";
                                    break;
                                case 12:
                                    val2 = "C";
                                    break;
                                case 13:
                                    val2 = "D";
                                    break;
                                case 14:
                                    val2 = "E";
                                    break;
                                case 15:
                                    val2 = "F";
                                    break;
                            }
                            placeholder = placeholder + val2;
                        }
                        else
                            placeholder = placeholder + val;
                        x = x / _secondBase;
                    }

                    for (int i = placeholder.Length - 1; i >= 0; i--)
                    {
                        secondNumber += placeholder[i];
                        j++;
                    }

                    Console.WriteLine("Numarul {0} din baza {1} in baza {2} este {3}", input, _base, _secondBase, secondNumber);

                }
                else
                    Console.WriteLine("Numarul {0} din baza {1} in baza {2} este {3}", input, _base, _secondBase, number);
            }
            else
            {
                int number = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    number = number * 10 + (int)input[i] - '0';
                }

                int x = number;
                string placeholder = "";
                string secondNumber = "";
                int j = 0;
                int val;
                string val2 = "";

                while (x != 0)
                {
                    val = x % _secondBase;

                    if (val > 9)
                    {
                        switch (val)
                        {
                            case 10:
                                val2 = "A";
                                break;
                            case 11:
                                val2 = "B";
                                break;
                            case 12:
                                val2 = "C";
                                break;
                            case 13:
                                val2 = "D";
                                break;
                            case 14:
                                val2 = "E";
                                break;
                            case 15:
                                val2 = "F";
                                break;
                        }
                        placeholder = placeholder + val2;
                    }
                    else
                        placeholder = placeholder + val;
                    x = x / _secondBase;
                }

                for (int i = placeholder.Length - 1; i >= 0; i--)
                {
                    secondNumber += placeholder[i];
                    j++;
                }

                Console.WriteLine("Numarul {0} din baza {1} in baza {2} este {3}", input, _base, _secondBase, secondNumber);
            }
        }
    }
}
