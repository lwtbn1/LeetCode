using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class 归并排序
    {

        public static void Test()
        {
            int[] retArray = Sort(new int[] { 1, 3, 5 }, new int[] { 2, 4, 6 });
            for (int i = 0; i < retArray.Length; i++)
                Console.Write(retArray[i]);
            Console.ReadKey();
        }

        public static int[] Sort(int[] array1, int[] array2)
        {
            int totalLen = array1.Length + array2.Length;
            int[] retArray = new int[totalLen];
            int pivot1 = 0;
            int pivot2 = 0;
            int pivot = 0;
            while(pivot1< array1.Length || pivot2 < array2.Length)
            {
                int minVal;
                if(pivot1 < array1.Length && pivot2 < array2.Length)
                {
                    int val1 = array1[pivot1];
                    int val2 = array2[pivot2];
                    if(val1 < val2)
                    {
                        minVal = val1;
                        pivot1++;
                    }else
                    {
                        minVal = val2;
                        pivot2++;
                    }
                    retArray[pivot++] = minVal;
                }else if(pivot1 < array1.Length && pivot2 >= array2.Length)
                {
                    retArray[pivot++] = array1[pivot1];
                    pivot1++;
                }else if (pivot1 >= array1.Length && pivot2 < array2.Length)
                {
                    retArray[pivot++] = array2[pivot2];
                    pivot2++;
                }
            }

            return retArray;
        }
    }
}
