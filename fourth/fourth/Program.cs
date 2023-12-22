using System;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../numsTask4.txt";
            using StreamReader reader = new StreamReader(path);

            string str = reader.ReadLine();
            int[] nums = str.Split(' ').Select(int.Parse).ToArray();

            int n = 0;

            for (int i = 1; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    n++;
                }
                else if (nums[i] == nums[i - 1])
                {
                    n++;
                }

                else if (nums[0] == nums[1])
                {
                    n++;
                }

                else if (nums[nums.Length - 1] == nums[nums.Length - 2])
                {
                    n++;
                }
            }
            Console.WriteLine(n);
        }
    }
}
