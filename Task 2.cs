using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 15, 95, 22, 31, 5 };

            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[max])
                {
                    numbers[max] = numbers[i];
                }



            }

            Console.WriteLine(numbers[max]);





        }
    }
}
