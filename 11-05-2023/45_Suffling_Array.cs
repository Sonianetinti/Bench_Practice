using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class _45_Suffling_Array
    {
        static void Main()
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter elements into an array:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();
            Console.WriteLine("Shuffled array was:");
            foreach (var j in arr)
            {
                Console.WriteLine(j);
            }
        }
    }
}

