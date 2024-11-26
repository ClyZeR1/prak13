using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Min(int x, int y)
        {
            return x < y ? x : y;
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static void Main(int result)
        {
            Console.WriteLine("Результат: " + result);
        }

        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int d = Input("d=");

            int minAB = Min(a, b);
            int minCD = Min(c, d);
            int s = minAB + minCD;
            Main(s);

            Console.ReadLine();
        }
    }
}