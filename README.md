## #1 ##
Print the number of integers in an array that are above the given input and the number that are below, e.g. for the array [1, 5, 2, 1, 10] with input 6, print “above: 1, below: 4”.
  - See ArrayApp.cs

## #2 ##
Rotate the characters in a string by a given input and have the overflow appear at the beginning, e.g. “MyString” rotated by 2 is “ngMyStri”.
  - See RotateCharApp.cs

## #3 ##
Codeland Username Validation

Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine if the string is a valid username according to the following rules:
  1. The username is between 4 and 25 characters.
  2. It must start with a letter.
  3. It can only contain letters, numbers, and the underscore character.
  4. It cannot end with an underscore character.

If the username is valid then your program should return the string true, otherwise return the string false.
  
  Examples

    Input 1: "aa_"
    Output 1: False
  
    Input 2: "u__hello_world123"
    Output 2: True

  - See CodelandUsernameValidation.cs

## #4 ## 
Formatted Number

  Have the function FormattedNumber(strArr) take the strArr parameter being passed, which will only contain a single element, and return the string true if it is a valid number that contains only digits with properly placed decimals & commas, otherwise return the string false.                   

For example: if strArr is ["1,093,222.04"] then your program should return the string true, but if the input were ["1,093,22.04"] then your program should return the string   false. The input may contain characters other than digits.                                                 

  Examples     
  
    Input 1: ["0.232567"]                                        
    Output 1: True                                               
                                                             
    Input 2: ["2,567.00.2"]                                      
    Output 2: False
    
  - See FormattedNumber.cs

## #5 ##
Seating Students

  Have the function SeatingStudents(arr) read the array of integers stored in arr which will be in the following format: [K, r1, r2, r3, ...] where K represents the number of desks in a classroom, and the rest of the integers in the array will be in sorted order and will represent the desks that are already occupied.All of the desks will be arranged in 2 columns, where desk #1 is at the top left, desk #2 is at the top right, desk #3 is below #1, desk #4 is below #2, etc. 

  Your program should return the number of ways 2 students can be seated next to each other. This means 1 student is on the left and 1 student on the right, or 1 student is directly above or below the other student.

  K will range from 2 to 24 and will always be an even number. After K, the number of occupied desks in the array can range from 0 to K. 
        
  Example
  
        Input: {6, 4}
        Output: 4
        
        Input: {8, 1, 8}
        Output: 6
        
  - See SeatingStudents.cs

## #6 ##
Angular Tic Tac Toe

  We provided some simple Angular template code. Your goal is to create a functioning Tic Tac Toe game. 
It should work the following way: the first player to go places an X anywhere on the board, and then the next player will be able to place an O, and it continues alternating like this every turn.

  You should also implement a function to determine if any player won by getting 3 X's or O's in a diagonal, horizontal, or vertical row. 
If there is a winner, display a message at the top. If nobody wins, then do not display any message. 
Finally, you should also implement the reset function that resets the entire board. You should also not be able to override the other players move during the game.

  You are free to add classes and styles, but make sure you leave the element ID's as they are. 
Submit your code once it is complete and our system will validate your output.

  - See AngularTicTacToe.ts

## #7 ##
Reverse Words

  You are given an integer N, followed by N lines of input (1 <= N <= 100). Each line of input contains one or several words separated with single spaces. Each word is a sequence of letters of English alphabet containing between 1 and 10 characters, inclusive. The total number of words in the input is between 1 and 100, inclusive.

  Your task is to reverse the order of words in each line of input, while preserving the words themselves. The lines of your output should not have any trailing or leading spaces.

Example

    input:
    3
    Hello World
    Bye World
    Useless World

    output:
    World Hello
    World Bye
    World Useless
    
  - See ReverseWord.cs

## #8 ##
Number of Piles

  You have N boxes in your room which you want to carry to a different place. There are too many to carry in one trip, so you want to split them into several piles using the following algorithm: if the current pile has at most M boxes, you can carry it as is, otherwise you split it into P parts as equally as possible (i.e. so that the sizes of the parts differ at most by 1) and apply the same algorithm to each of the parts. If you're trying to split less than P boxes into P piles, discard resulting zero-sized piles (see example 2).

  Calculate the number of piles you'll get in the end.

  The only line of input contains three space-separated integers: N, M and P. 1 <= N <= 100, 1 <= M <= 5, 2 <= P <= 5.

Example 1

    input:
    11 2 2

    output:
    7

    The sequence of pile splits you do is:

    11 -> 6 + 5
    6 -> 3 + 3
    5 -> 3 + 2
    3 -> 2 + 1 (applied to three piles of 3 boxes each)

    You end up with 4 piles of 2 boxes and 3 piles of 1 boxes, a total of 7 piles.

Example 2

    input:
    3 2 5

    output:
    3

    You have to split a pile of 3 boxes into 5 parts, so you get 3 piles of 1 box and 2 empty piles which you discard.

  - See NumberOfPiles.cs
