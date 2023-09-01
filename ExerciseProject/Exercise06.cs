using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    internal class Exercise06
    {
        public static void Main6(string[] args)
        {
            int first_number;
            int second_number;
            int third_number;


            Console.Write("Input the first Number:");
            first_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second Number:");
            second_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third Number:");
            third_number = Convert.ToInt32(Console.ReadLine());

            int result = first_number * second_number * third_number;

            Console.WriteLine("{0} x {1} x {2} = {3}",first_number,second_number,third_number,result);
            Console.ReadKey();
        }
    }
}
