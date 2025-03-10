using System;

namespace HitungArray
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] inpt = Console.ReadLine().Split();
            int[] angka = new int[N];

            for (int i = 0; i < N; i++)
            {
                angka[i] = int.Parse(inpt[i]);
            }

            int maxsum = int.MinValue;
            int cursum = 0;
            int awal = 0, akhir = 0, temp = 0;

            for (int i = 0; i < N; i++)
            {  
                cursum += angka[i];
                if (cursum > maxsum)
                {
                    maxsum = cursum;
                    awal = temp;
                    akhir = i;
                }
               
                if (cursum < 0)
                {
                    cursum = 0;
                    temp = i + 1;
                }
            }
            Console.WriteLine(maxsum);
            Console.WriteLine($"{awal} {akhir}");
        }
    }
}