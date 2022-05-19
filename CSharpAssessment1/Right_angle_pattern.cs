using System;


namespace CSharpAssessment1
{
    public class Right_angle_pattern
    {
        public void RightTrianglePattern()
        {
            try
            {
                Console.Write("Enter a number: ");
                int num;
                bool IsNum = Int32.TryParse(Console.ReadLine(), out num);
                if (IsNum)
                {
                    Console.Write("Enter width: ");
                    int b;
                    bool IsWidth = Int32.TryParse(Console.ReadLine(), out b);
                    Console.WriteLine();
                    if (IsWidth && b != 0)
                    {
                        for (int rows = 0; rows < b; rows++)
                        {
                            for (int height = b; height > rows; height--)
                            {
                                Console.Write(num);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid width and it should be greater than 0");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
        }
    }
}
