using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment1
{
    public class SumOfDigits
    {
        public static void AddNumber()
        {
            try
            {
                int number;
                Console.Write("Enter a number: ");
                bool IsTrue = Int32.TryParse(Console.ReadLine(), out number);
                int m, sum = 0;
                if (IsTrue)
                {
                    while (number > 0)
                    {
                        m = number % 10;
                        sum = sum + m;
                        number /= 10;
                    }
                    Console.WriteLine("The sum of the digits of the number is {0}", sum);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

    }
}
