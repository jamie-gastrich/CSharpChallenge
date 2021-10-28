using System;
using System.Collections.Generic;

namespace SeatingStudents
{
    class Program
    {
        public static int SeatingStudents(int[] seats)
        {
            int count = 0;
            if (seats.Length > 1)
            {
                HashSet<int> seatsTaken = new HashSet<int>();
                for (int i = 1; i < seats.Length; i++)
                {
                    seatsTaken.Add(seats[i]);
                }
                for (int i = 1; i <= seats[0]; i++)
                {
                    if (seatsTaken.Contains(i)) continue; //is seat taken
                    if (i % 2 != 0) //is number odd
                    {
                        if (!seatsTaken.Contains(i + 1)) count++; //Check if even seat to right is empty
                    }
                    if (!seatsTaken.Contains(i + 2) && ((i + 2) <= seats[0])) count++; //Check if seat below is empty and exists
                }
            }
            return count;

        }
        static void Main()
        {
            int[] input = { 6, 4 }; //4
            //int[] input = { 8, 1, 8 }; //6
            //int[] input = { 6, 3 }; //4 
            //int[] input = { 8, 1, 2 }; //7 
            //int[] input = { 4, 1, 2, 3, 4 }; //0
            //int[] input = { 4 }; //0
            Console.WriteLine(SeatingStudents(input));
        }
    }
}
