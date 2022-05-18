using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment1
{
    public class StarPattern
    {
        public void StarTriangle()
        {
            Console.Write("Enter number of rows: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int rows = 0; rows < n; rows++)
            {
                for (int space = 1; space < n - rows; space++)
                {
                    Console.Write(' ');
                }
                for (int height = 0; height <= rows; height++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
        }
    }
}
