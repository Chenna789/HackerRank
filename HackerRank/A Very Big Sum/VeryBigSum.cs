using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Simple_Array_Sum
{
    class VeryBigSum
    {
        //For used for efficiency
        public long CalculateSum_UsingFor(long[] arr)
        {
            long sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //foreach used for elegancy - fancy way of writing/makes code readable
        public long CalculateSum_UsingForEach(long[] arr)
        {
            long sum = 0;
            int i = 0;
            foreach(var item in arr)
            {
                sum += item;
                i++;
            }
            return sum;
        }
        public long CalculateSum_UsingArrayForEach(long[] arr)
        {
            long sum = 0;
            Array.ForEach(arr, x => sum = sum + x);
            return sum;
        }
        //using aggregate function in linq
        public long CalculateSum_Using_Linq_Aggregate(long[] arr)
        {
            return arr.Aggregate((first, second) => first + second);
        }     
        //using sum function in linq
        public long CalculateSum_Using_Linq_IENumerable_Sum(long[] arr)
        {
            return arr.Sum();
        }
    }
}
