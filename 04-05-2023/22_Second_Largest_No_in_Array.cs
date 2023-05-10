using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class _22_Second_Largest_No_in_Array
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");

            int  n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("------------------");
            for(int i=0;i<arr.Length;i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());
               

            }
            Array.Sort(arr);
            Console.WriteLine($"second largest no in an array is: {arr[n-2]}");


        }
    }
}
