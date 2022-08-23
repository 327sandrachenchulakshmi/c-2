using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class program32
    {
        public static void swap(ref int a, ref int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;
        }
        public static void Main()
        {
            int a = 10, b = 15;
            Console.WriteLine($"swapping before a={a} b={b}");
            swap(ref a, ref b);
            Console.WriteLine($"swapping after a={a} b={b}");
        }
    }
}
