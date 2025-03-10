using System;

namespace Data_Structure
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int arrcnt1 = int.Parse(input[0]);
            int arrcnt2 = int.Parse(input[1]);

            string[] arr1 = Console.ReadLine().Split();
            string[] arr2 = Console.ReadLine().Split();

            bool similar;

            for (int i = 0; i < arrcnt1; i++)
            {
                similar = false;
                for (int j = 0; j < arrcnt2; j++)
                {
                    if(arr1[i] == arr2[j])
                    {
                        similar  = true;
                        break;
                    }  
                }
                if (!similar) Console.Write($"{arr1[i]} ");
            }
        }
    }
}
