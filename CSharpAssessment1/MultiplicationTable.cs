using System;
namespace CSharpAssessment1
{
    public class MultiplicationTable
    {
        public void Table()
        {
            Console.WriteLine("Enter a number you want to print a table of  ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number till which you want to print the table: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Multiplication Table of {0} to {1}", num, n);
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0} x {1} = {2} ", num, i, num * i);
            }
        }
    }
}
