using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Simple_Array_Sum
{
    class SimpleArraySum
    {
        //For used for efficiency
        public int CalculateSum_UsingFor(int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        //foreach used for elegancy - fancy way of writing/makes code readable
        public int CalculateSum_UsingForEach(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
                sum += item;
            return sum;
        }
        public int CalculateSum_UsingArrayForEach(int[] arr)
        {
            int sum = 0;
            Array.ForEach(arr, i => sum += i);
            return sum;
        }
        //using aggregate function in linq
        public int CalculateSum_Using_Linq_Aggregate(int[] arr)
        {
            return arr.Aggregate((x, y) => x + y);
        }     
        //using sum function in linq
        public int CalculateSum_Using_Linq_IENumerable_Sum(int[] arr)
        {
            return arr.Sum();
        }
    }
}
