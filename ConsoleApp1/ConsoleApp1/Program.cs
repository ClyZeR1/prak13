using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static int Seconds(int h, int m, int s)
        {
            return h * 3600 + m * 60 + s;
        }
        static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int h1 = 0, m1 = 40, s1 = 20;
            int total1 = Seconds(h1, m1, s1);
            Console.WriteLine($"Кол-во секунд для {h1}ч {m1}м {s1}с: {total1}");

            int h2 = 3, m2 = 10, s2 = 50;
            int total2 = Seconds(h2, m2, s2);
            Console.WriteLine($"Кол-во секунд для {h2}ч {m2}м {s2}с: {total2}");

            Console.ReadLine();
        }
    }
}