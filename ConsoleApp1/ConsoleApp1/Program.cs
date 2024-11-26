using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Min(int x,int y)
        {
            return x < y ? x : y;
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int x = Input("x=");
            int y = Input("y=");
            int min = Min(x, y);
            Console.WriteLine(min);
            Console.ReadLine();
        }
    }
}
