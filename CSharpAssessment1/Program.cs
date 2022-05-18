using System;
using CSharpAssessment1;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Please Enter a number to select which program you want to run \n 1 To print a right angle triangle press 1 \n 2 To print table \n 3 print a star pattern \n 4 To calculate the sum of given digits\n ");
        string userInput = "";
        do
        {
               Console.Write("Enter your Choice: ");
               int  option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            Right_angle_pattern obj = new Right_angle_pattern();
                            obj.RightTrianglePattern();
                            break;
                        }
                    case 2:
                        {
                            MultiplicationTable obj2 = new MultiplicationTable();
                            obj2.Table();
                            break;
                        }
                    case 3:
                        {
                            StarPattern obj3 = new StarPattern();
                            obj3.StarTriangle();
                            break;
                        }
                    case 4:
                        {

                            SumOfDigits obj4 = new SumOfDigits();
                            Console.Write("Enter a number : ");
                            int a = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("The sum of the digits of the number {0} is {1} ", a, obj4.AddNumber(a));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid input, please enter a valid option");
                            break;
                        }
                }
            do
            {

                Console.WriteLine("Do you want to print another program - Yes or No ? ");
                userInput = Console.ReadLine().ToUpper();
                if (userInput != "YES" && userInput != "NO")
                {
                    Console.WriteLine("Invalid input, please enter YES or NO");
                }
            } while (userInput != "YES" && userInput != "NO");
            Console.Clear();
        } while (userInput == "YES");
    }
}

