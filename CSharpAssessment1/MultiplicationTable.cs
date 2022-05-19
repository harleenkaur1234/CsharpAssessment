using System;
namespace CSharpAssessment1
{
    public class MultiplicationTable
    {
        public void Table()
        {
            try
            {
                Console.WriteLine("Enter a number you want to print a table of  ");
                int num;
                bool IsNum = Int32.TryParse(Console.ReadLine(), out num);
                if (IsNum)
                {
                    Console.Write("Enter the number upto which you want to print the table: ");
                    int n;
                    bool IsSuccess = Int32.TryParse(Console.ReadLine(), out n);
                    if (IsSuccess)
                    {
                        Console.Write("Multiplication Table of {0} to {1}", num, n);
                        Console.WriteLine();
                        for (int i = 1; i <= n; i++)
                        {
                            Console.WriteLine("{0} x {1} = {2} ", num, i, num * i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number");
                    }
                }
                else
                {
                    Console.WriteLine("Input should be a number");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
