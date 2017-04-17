using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

            int currentMinimum = Int32.MaxValue; // We start high, so that any element in the array will be lower.   


            foreach(int value in array)
            {
                if (value < currentMinimum)
                    currentMinimum = value;

                Console.WriteLine("Minimum Value: " + currentMinimum); //for debugging
            }


            //for (int index = 0; index < array.Length; index++) {
            // if (array[index] < currentMinimum)
            //  currentMinimum = array[index]; } 

            // At this point, currentMinimum contains the minimum value in the array. 
            Console.ReadKey();
            
        }
    }
}
