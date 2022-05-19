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
            try {
                Console.Write("Enter number of rows: ");
                int nRows;
                bool IsNum = Int32.TryParse(Console.ReadLine(), out nRows);
                if (IsNum)
                {
                    if (nRows > 0)
                    {
                        for (int rows = 0; rows < nRows; rows++)
                        {
                            for (int space = 1; space < nRows - rows; space++)
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
                    else
                    {
                        Console.WriteLine("Rows should be greater than 0");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            }
    }
}
