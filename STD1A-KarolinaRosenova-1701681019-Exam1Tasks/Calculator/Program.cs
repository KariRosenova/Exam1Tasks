using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                string answer = string.Empty;
                float a, b;
                while (true)
                {
                    do  // pri otgovor no trqbva da se spre progr
                    {
                        if (answer != "no")
                        {
                            Console.WriteLine("Do you want to calculate some numbers? (yes or no)");
                            answer = Console.ReadLine();
                        }
                        else
                        {
                            Environment.Exit(0);
                        }

                    }

                    while (answer != "yes");
                    {
                        Console.WriteLine("Insert a number");
                        a = float.Parse(Console.ReadLine());
                        Console.WriteLine("Insert a second number");
                        b = float.Parse(Console.ReadLine());
                        Console.WriteLine("Choose an operation (+, -, * or /) ");

                        char operation = char.Parse(Console.ReadLine());
                        switch (operation)
                        {
                            case '+':
                                double result = (a + b) * 1.1;
                                Console.WriteLine("The result is: {0}", Math.Round(result, 2));
                                break;

                            case '-':
                                double maxNumber, minNumber;
                                if (a > b)
                                {
                                    maxNumber = a;
                                    minNumber = b;
                                }
                                else
                                {
                                    maxNumber = b;
                                    minNumber = a;
                                }
                                result = Math.Pow(maxNumber, 2) - minNumber;
                                Console.WriteLine("The result is: {0}", Math.Round(result, 2));
                                break;

                            case '*':
                                result = a * Math.Sqrt(b);
                                Console.WriteLine("The result is: {0}", Math.Round(result, 2));
                                break;

                            case '/':
                                if (b == 0)
                                {
                                    Console.WriteLine("You can't divide to 0!");
                                }
                                else
                                {
                                    result = a / b;
                                    Console.WriteLine("The result is: {0}", Math.Round(result, 2));
                                }

                                break;
                        }

                    }
                }
            }
            catch
            {
                Console.WriteLine("Insert a number!!!");
            }
            
        }
    }
}
