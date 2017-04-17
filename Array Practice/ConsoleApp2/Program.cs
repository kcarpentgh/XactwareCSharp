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
            int[] array1 = new[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 99 };
            int length = array1.Length;
            int[] array2 = new int [length];

            for(int x = 0; x < length; x++)
            {
                array2[x] = array1[x];
            }

            for (int y = 0; y < length; y++)
            {
                Console.WriteLine("Value from Array 1: " + array1[y]);
                Console.WriteLine("Value from Array 2: " + array2[y]);
            }

            Console.ReadKey();
        }
    }
}
