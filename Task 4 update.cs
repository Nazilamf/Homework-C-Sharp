using System;

namespace Task_4__update
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("num1:");
            string num1Str = Console.ReadLine();
            Console.WriteLine("num2:");
            string num2Str = Console.ReadLine();
            Console.WriteLine("num3:");
            string num3Str = Console.ReadLine();


            int num1 = Convert.ToInt32(num1Str);
            int num2 = Convert.ToInt32(num2Str);
            int num3 = Convert.ToInt32(num3Str);

            if (num1 >= 100 && num1 <= 1000)


                Console.WriteLine("Eded uc reqemlidir"!);

            else if (num2 >= 100 && num2 <= 1000)


                Console.WriteLine ("Eded uc reqemlidir"!);


            else if (num3 >= 100 && num3 <= 1000)

                Console.WriteLine("Eded uc reqemlidir"!);


            else

                Console.WriteLine("Eded uc reqemli deyildir!");
            
        }

    }
}
