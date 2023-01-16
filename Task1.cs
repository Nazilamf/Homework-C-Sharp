using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = 45;
            var b = 25;
            var c = 12;

            if (a<=b && a<= c)
            {
                Console.WriteLine(a);
            }
            else if (b<=a && b<=c)
            {
                Console.WriteLine(b);
            }

            else
            { 
            
               Console.WriteLine(c);
            }
                  

            
           
           
            
            
               
              
         
         
        }

    }
}
