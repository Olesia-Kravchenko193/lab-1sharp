using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, Z;
            Console.WriteLine("Введите целое число a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите целое число b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Z = Math.Pow((a - b), 2);
            Console.WriteLine("Z = " + Z);
        }
    }
}
