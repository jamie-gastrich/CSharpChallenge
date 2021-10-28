using System;

class MainClass
{

    public static string CodelandUsernameValidation(string str)
    {

        // code goes here 
        string Output = "True";
        bool MinLength = str.Length >= 4;
        bool MaxLength = str.Length <= 25;
        bool FisrtIsLetter = char.IsLetter(str[0]);
        bool LastIsNotUnderScore = str[str.Length - 1] != '_';

        if (MinLength && MaxLength && FisrtIsLetter && LastIsNotUnderScore)
        {
            foreach (char x in str.ToCharArray())
            {
                if (char.IsLetter(x) || char.IsNumber(x) || x.Equals('_'))
                {
                }
                else
                {
                    return "False";
                }
            }
        }
        else
        {
            Output = "False";
        }

        return Output;

    }

    static void Main()
    {
        string Input = "aa_"; //False
        //string Input = "u__hello_world123"; //True

        Console.WriteLine(CodelandUsernameValidation(Input));
    }

}
