using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    internal class Exercise07
    {
        public static void Main7(string[] args)
        {
            int first_number;
            int second_number;

            Console.Write("Input the first Number:");
            first_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second Number:");
            second_number = Convert.ToInt32(Console.ReadLine());

            int sum = first_number + second_number;
            int sub = first_number - second_number;
            int mul = first_number * second_number;
            int div = first_number / second_number;
            int mod = first_number % second_number;

            Console.WriteLine("{0} + {1}  = {2}", first_number, second_number,sum);
            Console.WriteLine("{0} - {1}  = {2}", first_number, second_number, sub);
            Console.WriteLine("{0} x {1}  = {2}", first_number, second_number, mul);
            Console.WriteLine("{0} / {1}  = {2}", first_number, second_number, div);
            Console.WriteLine("{0} mod {1}  = {2}", first_number, second_number, mod);
            Console.ReadKey();
        }
    }
}
