using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double v = 0; //volume
            double sa = 0; //surface area
            double pi = 3.1415926; //pi

            Console.WriteLine("Please input the radius of the cylinder."); 
            string UserInputRadius = Console.ReadLine(); //getting the radius from the user
            double r = Convert.ToInt32(UserInputRadius);

            Console.WriteLine("Please input the height of the cylinder.");
            string UserInputHeight = Console.ReadLine(); //getting the height from the user
            double h = Convert.ToInt32(UserInputHeight);

            v = (pi * ((r * r) * h));

            sa = ((2 * pi * r) * (r + h));

            Console.WriteLine("The volume of the cylinder is: " + v);
            Console.WriteLine("");
            Console.WriteLine("The surface area of the cylinder is: " + sa);
            Console.ReadKey();
        }
    }
}
