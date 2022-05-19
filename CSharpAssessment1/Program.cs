using System;
using CSharpAssessment1;
class Program
{
    public static void Main()
    {
        string userInput = "";
        int option;
        do
        {
            do
            {
                Console.WriteLine("Please Enter a number to select which program you want to run \n 1 To print a right angle triangle press 1 \n 2 To print table \n 3 Print a star pattern \n 4 To calculate the sum of given digits\n ");
            
                Console.Write("Enter your Choice: ");
                bool isValid = Int32.TryParse(Console.ReadLine(), out option);
                if (isValid)
                {
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
                                SumOfDigits.AddNumber();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine();
                                Console.WriteLine("Invalid input, please enter a valid option");
                                Console.WriteLine();
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                }
                do
                {

                    Console.WriteLine("Do you want to print another program - Yes or No ? ");
                    userInput = Console.ReadLine().ToUpper();
                    if (userInput != "YES" && userInput != "NO")
                    {
                        Console.WriteLine("Invalid input, please enter YES or NO");
                    }
                }
                while (userInput != "YES" && userInput != "NO");
                Console.Clear();

            } while (option != 1 || option != 2 || option != 3 || option != 4);
           // Console.Clear();
        } while (userInput == "YES");
    }
}

