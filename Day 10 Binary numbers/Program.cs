using System;

namespace Day_10_Binary_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int sum = 0;
            int max = 0;
            while (n > 0)
            {
                if (n % 2 == 1)
                {
                    sum++;

                    if (sum > max)
                    {
                        max = sum;
                    }
                }
                else
                {
                    sum = 0;
                }
                n = n / 2;
            }
            Console.WriteLine(max);
        }
    }
}
