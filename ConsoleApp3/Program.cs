using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 characters");
            Console.WriteLine("Enter first character");
            char a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter second character");
            char b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter third character");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("You enter {0}, {1}, {2}", a, b, c);
        }
    }
}
