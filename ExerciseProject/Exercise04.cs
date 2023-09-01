using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    internal class Exercise04
    {
        public static void Main4(string[] args)
        {
            var result1 = -1 + 4 * 6;
            var result2 = (35 + 5) % 7;
            var result3 = 14 + -4 * 6 / 11;
            var result4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);

            Console.ReadKey();
        }
    }
}