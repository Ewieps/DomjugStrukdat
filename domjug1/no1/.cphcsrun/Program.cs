using System;
namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int N = int.Parse(arr[0]);
            int B = int.Parse(arr[1]);
            int idx = 0;
            string[] arrn = Console.ReadLine().Split();
            
            for (int i = 0; i < N; i++)
            { 
                if (int.Parse(arrn[i]) == B)
                {
                    idx++;
                }
            }
            Console.WriteLine(idx);

        }
    }
}