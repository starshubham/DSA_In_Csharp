using System;

namespace SumOfDigits
{
    class Program
    {
        public static int SumOfDigits(int n)
        {
            if (n / 10 == 0)
                return n;
            return SumOfDigits(n / 10) + n % 10;
        }
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of digits of the given number " + n + " = " + SumOfDigits(n));
        }
    }
}
