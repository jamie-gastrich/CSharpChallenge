using System;

namespace RotateCharApp
{
    class RotateCharApp
    {
        static void Main(string[] args)
        {
            //Declare variables
            int num = 0;
            string RotateMe = "MyString";
            string MeRotate;
            char UIString;

            //Prompt the user if they want to enter their own array
            Console.WriteLine("Enter your own String? (Y/N)");
            UIString = char.Parse(Console.ReadLine());

            if (UIString == 'Y' || UIString == 'y')
            {
                //Prompt the user to input their array
                Console.WriteLine("Enter the string you want to rotate");

                //Set up user input array
                RotateMe = Console.ReadLine();

                //Show the string and tell the user the max integer they can input
                Console.WriteLine("The string is \"" + RotateMe + "\" " + "and the highest integer you can input is " + RotateMe.Length);

                //Propt the user to enter the integer they want to test
                Console.WriteLine("Enter the integer you want to rotate the string on");
                try
                {
                    //Set user input integer
                    num = int.Parse(Console.ReadLine());

                    //Rotate the characters in the string
                    MeRotate = string.Format("{0}{1}", RotateMe.Substring(RotateMe.Length - num), RotateMe.Substring(0, RotateMe.Length - num));

                    //Output Above, Below and the Array
                    Console.WriteLine("Original String: " + RotateMe);
                    Console.WriteLine("Rotated String: " + MeRotate);

                }
                //If the user inputs anything other than an integer or an integer greater than the string length, it will fail with this note
                catch
                {
                    if (num > RotateMe.Length)
                    {
                        Console.WriteLine("Please enter an integer that is less than the string length next time");
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer next time");
                    }
                }
            }
            else if (UIString == 'N' || UIString == 'n')
            {
                //Show the string and tell the user the max integer they can input
                Console.WriteLine("The string is \"" + RotateMe + "\" " + "and the highest integer you can input is " + RotateMe.Length);

                //Propt the user to enter the integer they want to test
                Console.WriteLine("Enter the integer you want to rotate the string on");

                try
                {
                    //Set user input integer
                    num = int.Parse(Console.ReadLine());

                    //Rotate the characters in the string
                    MeRotate = string.Format("{0}{1}", RotateMe.Substring(RotateMe.Length - num), RotateMe.Substring(0, RotateMe.Length - num));

                    //Output Above, Below and the Array
                    Console.WriteLine("Original String: " + RotateMe);
                    Console.WriteLine("Rotated String: " + MeRotate);

                }
                //If the user inputs anything other than an integer or an integer greater than the string length, it will fail with this note
                catch
                {
                    if (num > RotateMe.Length)
                    {
                        Console.WriteLine("Please enter an integer that is less than the string length next time");
                    }
                    else
                    {
                        Console.WriteLine("Please enter an integer next time");
                    }
                }
            }
            //If the user inputs anything other than a y or n 
            else
            {
                Console.WriteLine("Please enter either a Y for yes or N for no next time");
            }
        }
    }
}
