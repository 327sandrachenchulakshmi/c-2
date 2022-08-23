namespace ConsoleApp3
{
    internal class Program
    {
        public static int mul_num(int a, int b, int c)
        {
            return a * b * c;
           
        }
        public static void Main()
        {
            int a, b, c;
            Console.WriteLine("enter a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter c");
            c = Convert.ToInt32(Console.ReadLine());
            int result= mul_num(a, b, c);
            Console.WriteLine($"the output is {result}");
        }
    }
}