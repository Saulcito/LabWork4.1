using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 11); // to 11 because that number does not count
            }

            Console.WriteLine("Exit of numbers");
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            int product = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 6) 
                {
                    product *= array[i];
              
                }
            }
            Console.WriteLine($"The product of the elements found less than 6 is: {product}");
            Console.ReadKey();
     
         

        }
    }
}
