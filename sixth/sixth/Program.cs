using System;
namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            double x =double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double x1 = 0;
            double x2 = 2;
            double x3 = -2;
            double y1 = 2;
            double y2 = -3;
            double y3 = -3;

            double a = (x1 - x) * (y2 - y1) - (x2 - x1) * (y1 - y);
            double b = (x2 - x) * (y3 - y2) - (x3 - x2) * (y2 - y);
            double c = (x3 - x) * (y1 - y3) - (x1 - x3) * (y3 - y);

            if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
