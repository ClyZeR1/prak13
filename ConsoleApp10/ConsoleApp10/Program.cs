using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Numbers(int n)
        {
            for (int i = 2; i <= n; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Numbers(20);
            Numbers(50);

            Console.Write("m:");
            int m = int.Parse(Console.ReadLine());
            Numbers(m);

            Console.ReadLine();
        }
    }
}