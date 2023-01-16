using System;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 6, 72, 12, 8 };

            int sum = 0;
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }
            Console.WriteLine(sum / count);
        }
    }
}
