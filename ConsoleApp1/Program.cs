using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Min(int a, int b, int c)
        {
            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static void Output(int result)
        {
            Console.WriteLine("Минимальное значение: " + result);
        }

        static void Main(string[] args)
        {
            int a = Input("a = ");
            int b = Input("b = ");
            int c = Input("c = ");

            int min = Min(a, b, c);

            Output(min);

            Console.ReadLine();
        }
    }
}
