using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static double Average(int m, int n)
        {
            int sum = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return (double)sum / count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Average(1, 10));
            Console.WriteLine(Average(20, 40));
            Console.Write("a:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Average(a, b));

            Console.ReadLine();
        }
    }
}