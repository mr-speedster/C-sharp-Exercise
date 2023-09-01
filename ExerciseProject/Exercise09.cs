using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    internal class Exercise09
    {
        public static void Main9(string[] args)
        {
            int first_number;
            int second_number;
            int third_number;
            int fourth_number;

            Console.Write("Enter the first Number:");
            first_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second Number:");
            second_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third Number:");
            third_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the fourth Number:");
            fourth_number = Convert.ToInt32(Console.ReadLine());

            int avg = (first_number + second_number + third_number + fourth_number) / 4;

            Console.WriteLine("The average of {0}, {1}, {2}, {3} is: {4}", first_number, second_number, third_number, fourth_number, avg);
            Console.ReadKey();
        }
    }
}
