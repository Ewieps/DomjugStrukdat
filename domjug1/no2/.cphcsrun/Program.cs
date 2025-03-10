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

            for (int i = 0; i < num; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            int sum = 0;

            for (int i = 1; i < num - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    sum += arr[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}


// using System;

// namespace Data_Structure
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string[] arr = Console.ReadLine().Split();
//             int rep = int.Parse(arr[0]);
//             string[] inpt = Console.ReadLine().Split();

//             int sum = 0;
//             int first = int.Parse(inpt[0]);
//             int last = int.Parse(inpt[rep - 1]);

//             for (int i = 1; i < rep - 1; i++)
//             {
//                 int current = int.Parse(inpt[i]);
//                 if (current != first && current != last)
//                 {
//                     int prev = int.Parse(inpt[i - 1]);
//                     int next = int.Parse(inpt[i + 1]);
//                     if (current > prev && current > next) sum += current;
//                 }
//             }
//             Console.WriteLine(sum);
//         }
//     }
// }
