using System;

namespace ArrayApp
{
    class ArrayApp
    {
        static void Main(string[] args)
        {
            //Declare variables
            int Below = 0;
            int Above = 0;
            int num = 0;
            int[] numArray = { 1, 5, 2, 1, 10 };
            char UIArray;

            //Prompt the user if they want to enter their own array
            Console.WriteLine("Enter your own Array? (Y/N)");
            UIArray = char.Parse(Console.ReadLine());

            if (UIArray == 'Y' || UIArray == 'y')
            {
                //Prompt the user to input their array
                Console.WriteLine("Enter a 5 digit long array");

                //Set up user input array
                for (int i = 0; i < 5; i++)
                {
                    numArray[i] = int.Parse(Console.ReadLine());
                }

                //Propt the user to enter the number they want to test
                Console.WriteLine("Enter a number to see how many are above and below it in the array");
                try
                {
                    //Set user input number
                    num = int.Parse(Console.ReadLine());

                    //Figure out count for Above and Below 
                    for (int i = 0; i < 5; i++)
                    {
                        if (numArray[i] > num)
                        {
                            Above++;
                        }
                        else if (numArray[i] < num)
                        {
                            Below++;
                        }
                    }

                    //Output Above, Below and the Array
                    Console.WriteLine("Above: " + Above);
                    Console.WriteLine("Below: " + Below);
                    Console.WriteLine("Array = [" + numArray[0] + ", " + numArray[1] + ", " + numArray[2] + ", " + numArray[3] + ", " + numArray[4] + "]");

                }
                //If the user inputs anything other than an integer, it will fail with this note
                catch
                {
                    Console.WriteLine("Please enter an integer");
                }
            }
            else if (UIArray == 'N' || UIArray == 'n')
            {
                //Propt the user to enter the number they want to test
                Console.WriteLine("Enter a number to see how many are above and below it in the array");
                
                try
                {
                    //Set user input number
                    num = int.Parse(Console.ReadLine());

                    //Figure out count for Above and Below 
                    for (int i = 0; i < 5; i++)
                    {
                        if (numArray[i] > num)
                        {
                            Above++;
                        }
                        else if (numArray[i] < num)
                        {
                            Below++;
                        }
                    }

                    //Output Above, Below and the Array
                    Console.WriteLine("Above: " + Above);
                    Console.WriteLine("Below: " + Below);
                    Console.WriteLine("Array = [" + numArray[0] + ", " + numArray[1] + ", " + numArray[2] + ", " + numArray[3] + ", " + numArray[4] + "]");

                }
                //If the user inputs anything other than an integer, it will fail with this note
                catch
                {
                    Console.WriteLine("Please enter an integer");
                }
            }
            //If the user inputs anything other than a y or n 
            else
            {
                Console.WriteLine("Please enter either a Y for yes or N for no");
            }
        }
    }
}
