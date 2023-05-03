using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class _23_Sort_Of_Array_Without_InBuilt_Function
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the array size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            int[] num1 = new int[n];
            int i,j,k,temp;

            Console.WriteLine("----");
            for( k=0;k<num.Length;k++)
            {
                num[k] = Convert.ToInt32(Console.ReadLine());
            }

            //copying an array from one array to another array
            //Array.CopyTo(num, num1);




            for ( i = 1; i < num.Length; i++)
            {

                for ( j = 0; j < num.Length - i; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Array in ascending order is");
            foreach(var v in num)
            {
                temp = v;
                    Console.WriteLine(v);
            }



            

            
        }
    }
}
