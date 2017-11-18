using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int radius = rnd.Next(33, 187);
            double area = Math.PI * radius * radius;
            area = Math.Round(area, 2);
            Console.WriteLine("The circle radius is = {0}", radius);
            Console.WriteLine("The circle area is = {0}", area);
        }
    }
}
