/**
*Codeland Username Validation
*Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine if the string is a valid username according to the following rules:
*
*1. The username is between 4 and 25 characters.
*2. It must start with a letter.
*3. It can only contain letters, numbers, and the underscore character.
*4. It cannot end with an underscore character.
*
*If the username is valid then your program should return the string true, otherwise return the string false.
*Examples
*Input: "aa_"
*Output: false
*Input: "u__hello_world123"
*Output: true
**/
using System;

class MainClass {

  public static string CodelandUsernameValidation(string str) {

    // code goes here 
    string Output = "True"; 
    bool MinLength = str.Length >= 4; 
    bool MaxLength = str.Length <= 25;
    bool FisrtIsLetter = char.IsLetter(str[0]);
    bool LastIsNotUnderScore = str[str.Length-1] != '_';

    if (MinLength && MaxLength && FisrtIsLetter && LastIsNotUnderScore) 
      {
        foreach(char x in str.ToCharArray())
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

  static void Main() {  
    // keep this function call here
    Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
  } 

}
