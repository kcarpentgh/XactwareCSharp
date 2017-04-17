using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the start.");
            for(int row = 0; row == 5; row++)
            {
                Console.WriteLine("1");
                Console.WriteLine($"Loop {row}");

                /*for(int column = 0; column == 9; column++)
                {
                    Console.WriteLine($"Loop {column}");
                    if (row == 0 && column == 5)
                        Console.Write("*");

                        else if(row == 1 && (column >= 4 && column <= 6))
                            Console.Write("*");
                        else if(row == 2 && (column >= 3 && column <= 7))
                            Console.Write("*");
                        else if(row == 3 && (column >= 2 && column <= 8))
                            Console.Write("*");
                        else if(row == 4 && (column >= 1 && column <= 9))
                            Console.Write("*");
                        else if(row == 5 && (column >= 0 && column <= 10))
                            Console.Write("*");
                    else Console.Write(" ");

                    Console.WriteLine();
                    
                }*/
            }

            Console.ReadKey();
        }
    }
}
