using System;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a >= -1 && a <= 3 && b >= -2 && b <= 4)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
