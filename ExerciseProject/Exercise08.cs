using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseProject
{
    internal class Exercise08
    {
        public static void Main8(string[] args)
        {
            int number;

            Console.Write("Enter the Number:");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}",number,i,number*i);
            }

            Console.ReadKey();
        }
    }
}
