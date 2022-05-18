using System;


namespace CSharpAssessment1
{
    public class Right_angle_pattern
    {
        public void RightTrianglePattern()
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int rows = 0; rows < b; rows++)
            {
                for (int height = b; height > rows; height--)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }
        }
    }
}
