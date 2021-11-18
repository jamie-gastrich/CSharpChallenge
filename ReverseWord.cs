using System;
using System.Linq;

namespace ReverseWord
{
    class Program
    {
        public static void Main()
        {
            int iterations = int.Parse(Console.ReadLine());
            string[] input = new string[iterations];
            string[] output = new string[iterations];
            for (int i = 0; i < iterations; i++)
            {
                input[i] = Console.ReadLine();
            }
            for (int j = 0; j < iterations; j++)
            {
                var array = input[j].Split(' ');
                string lastElem = array.First();
                string firstElem = array.Last(); 
                output[j] = firstElem + " " + lastElem;
                Console.WriteLine(output[j]);
            }
        }
    }
}
