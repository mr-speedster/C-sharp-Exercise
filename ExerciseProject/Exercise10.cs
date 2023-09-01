using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    internal class Exercise10
    {
        public static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.Write("Enter the first Number:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second Number:");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third Number:");
            z = Convert.ToInt32(Console.ReadLine());

            int exp1 = (x + y) * z;
            int exp2 = x*y + y*z;

            Console.WriteLine("Result of specified numbers {0}, {1}, {2}, (x + y) . z is {3} and  x.y + y.z is {4}",x,y,z,exp1,exp2);
            Console.ReadKey();
        }
    }
}
