using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class program2
    {
        public static string smallnumber(int a,int b,out string c)
        {
   
            if (a < b)
               return c = "a";
            else
                return c = "b";

        }
        public static void Main()
        {
            int a, b;
            Console.Write("First number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number");
            b = Convert.ToInt32(Console.ReadLine());
            string result = smallnumber(a, b, out result);
            
            Console.WriteLine($"the out put is {result} ");
        }
    }
}
    



    

