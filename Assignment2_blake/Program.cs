using System;

namespace Assignment2_blake
{
    class Program
    {
        static void Main(string[] args)
        {
            char input1 = 'y';
            while (input1 == 'y')
            {
                Console.WriteLine("Please enter a number between 1 & 100.");
                int input = int.Parse(Console.ReadLine());
                if (input >= 1 && input <= 100)
                {


                    if (input % 2 == 1)
                    {
                        if (input > 60)
                        {
                            Console.WriteLine($"{input} is odd");
                        }
                        else
                        {
                            Console.WriteLine($"The integer is odd");

                        }
                    }
                    if (input % 2 == 0)
                    {
                        if (input > 60 && input <=100)
                        {
                            Console.WriteLine($"{input} is even.");
                        } else if(input >=26 && input <=60)
                        {
                            Console.WriteLine($"the integer is even");
                        }else if (input >= 2 && input <= 25)
                        {
                            Console.WriteLine($"The integer is even and less than 25");
                        }
                    }

                    Console.WriteLine(" Would you like to Continue? Y/N");
                    input1 = char.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Invalid");
                    input1 = 'y';
                }

               
            }
              while(input1 == 'n')
            {
                Console.WriteLine("You have ended your session.");
                break;
            }
            
        }
    }
}
