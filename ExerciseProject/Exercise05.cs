using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    internal class Exercise05
    {
        public static void Main5(string[] args)
        {
            int first_number;
            int second_number;

            Console.Write("Input the First Number:");
            first_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number:");
            second_number = Convert.ToInt32(Console.ReadLine());

            int temp = first_number;
            first_number= second_number;
            second_number= temp;

            Console.WriteLine("Expected Output After Swapping:");
            Console.WriteLine("First Number:{0}", first_number);
            Console.WriteLine("Second Number:{0}", second_number);

            Console.ReadKey();
        }
    }
}
