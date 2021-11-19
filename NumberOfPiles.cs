using System;

namespace NumberOfPiles
{
    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            int N = int.Parse(input[0]); //Number of boxes 1 <= N <= 100
            int M = int.Parse(input[1]); //Max carry load 1 <= M <= 5
            int P = int.Parse(input[2]); //Parts to divide each pile to be under Max carry load 2 <= P <= 5
            int[] array = new int[P];
            int count = 0;
            int output = 0;

            if (N > P)
            {
                for (int i = 0; i < P; i++)
                {
                    count++;
                    array[i] = N / P;
                }
                if (N % P != 0)
                {
                    array[0] = array[0] + (N % P);
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if(array[i] > P)
                    {
                        if (array[i] > M)
                        {
                            Array.Resize<int>(ref array, array.Length + P);
                            for (int j = 0; j < P; j++)
                            {
                                count++;
                                array[count - 1] = array[i] / P;
                            }

                            if (array[i] % P != 0)
                            {
                                array[array.Length - P] = array[array.Length - P] + array[i] % P;
                            }
                        }
                    }
                    else
                    {
                        if (array[i] > M)
                        {
                            Array.Resize<int>(ref array, array.Length + P);
                            for (int j = 0; j < array[i]; j++)
                            {
                                count++;
                                array[count - 1] = 1;
                            }
                        }

                    }
                }
                foreach (var item in array)
                {
                    if (item <= M && item > 0)
                    {
                        output++;
                    }
                }

                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine(N);
            }
        }
    }
}
