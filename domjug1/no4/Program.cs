using System;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split();
            int[] arr = new int[num];

            int oddnum = 0;
            int evenum = 0;

            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < num; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    oddnum += arr[i];
                }
                else 
                {
                    evenum += arr[i];
                }
            }
            Console.Write($"{evenum} {oddnum}");
        }
    }
}

