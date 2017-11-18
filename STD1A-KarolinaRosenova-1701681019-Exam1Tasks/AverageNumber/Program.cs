using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int x = 0;
                int average;
                int number = 0;
                int counter=0;
                
                do
                {
                    Console.WriteLine("Enter a number:");
                    number = int.Parse(Console.ReadLine());
                    if (number >=1 && number <= 255)
                    {
                        if (number % 2 == 0)
                        {
                            counter++;
                            x = x + number;
                        }
                    }
                    else if (number <0)
                    {
                        Console.WriteLine("Entered number doesn't belong to this diapason [1, 255]");
                        break;
                    }
                }

                while (number != 0);
                {
                    average = x / counter;
                    Console.WriteLine("Finished!! Result: {0}", average);

                }
 
            }
            catch
            {
                Console.WriteLine("Insert numbers between 1 and 255!!!");
            }
        }
    }
}
