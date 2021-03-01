using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Min_Max_Sum
{
    class MinMaxSum
    {
        public void Find_O_n2(int[] arr)
        {
            //Complexity O(n2) + Min(O(n) + Max(O(n). Finally O(n)
            List<long> resultList = new List<long>();
            for (int i = 0; i < arr.Length; i++)
            {
                long sum = 0;
                for(int j = 0; j < arr.Length; j++)
                {
                    if (i == j)
                        continue;
                    sum += arr[j];
                }
                resultList.Add(sum);
            }
            Console.WriteLine($"{resultList.Min()} {resultList.Max()}");
        }
        public void Find_Static(int[] arr)
        {
            //Array is of exactly 5 length
            //Complexity O(1) but not dynamic
            long sum1 = (long)arr[1] + (long)arr[2] + (long)arr[3] + (long)arr[4];
            long minSum = sum1, maxSum = sum1;
            long sum2 = (long)arr[0] + (long)arr[2] + (long)arr[3] + (long)arr[4];
            maxSum = sum2 > maxSum ? sum2 : maxSum;
            minSum = sum2 < minSum ? sum2 : minSum;
            long sum3 = (long)arr[0] + (long)arr[1] + (long)arr[3] + (long)arr[4];
            maxSum = sum3 > maxSum ? sum3 : maxSum;
            minSum = sum3 < minSum ? sum3 : minSum;
            long sum4 = (long)arr[0] + (long)arr[1] + (long)arr[2] + (long)arr[4];
            maxSum = sum4 > maxSum ? sum4 : maxSum;
            minSum = sum4 < minSum ? sum4 : minSum;
            long sum5 = (long)arr[0] + (long)arr[1] + (long)arr[2] + (long)arr[3];
            maxSum = sum5 > maxSum ? sum5 : maxSum;
            minSum = sum5 < minSum ? sum5 : minSum;

            Console.WriteLine($"{minSum} {maxSum}");
        }

        public void Find_Using_Sort_Static(int[] arr)
        {
            //Sorting array O(n log n) + remaining O(1). Finally O(n log n): static
            Array.Sort(arr);
            long minSum = (long)arr[0] + (long)arr[1] + (long)arr[2] + (long)arr[3];
            long maxSum = (long)arr[1] + (long)arr[2] + (long)arr[3] + (long)arr[4];
            Console.WriteLine($"{minSum} {maxSum}");
        }
        public void Find_Using_Sort(int[] arr)
        {
            //Sorting array O(n log n) + remaining O(n). Finally O(n log n): dynamic
            Array.Sort(arr);
            long minSum = 0, maxSum = 0;
            for(int i = 0, j = arr.Length - 1; i < arr.Length - 1; i++, j--)
            {
                minSum += arr[i];
                maxSum += arr[j];

            }
            Console.WriteLine($"{minSum} {maxSum}");
        }

        public void Find_Using_Sum_And_Max_Min(int[] arr)
        {
            //This needs Three times array iteration, one is to find Sum, one is to find max and one more to min
            //Complexity is O(n)
            // Linq expressions(Sum ,Max, Min) will give poor performance
            //long totalSum = arr.Sum();//This will give overflowexception if the sum of the elements overflows
            long totalSum = arr.Sum(x => (long)x);
            Console.WriteLine($"{totalSum - arr.Max()} {totalSum - arr.Min()}");
        }
        public void Find_O_n_Using_Three_For_Loops(int[] arr)
        {
            //Complexity O(n) + O(n) + O(n). Finally O(n)
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            long min = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }

            long max = arr[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }

            Console.WriteLine($"{sum - max} {sum - min}");
        }
        public void Find_O_n_Using_Three_ForEach_Loops(int[] arr)
        {
            //Complexity O(n) + O(n) + O(n). Finally O(n)
            long sum = 0;
            foreach(var item in arr)
                sum += item;

            long min = arr[0];
            foreach(var item in arr)
            {
                if (item < min)
                    min = item;
            }

            long max = arr[0];
            foreach (var item in arr)
            {
                if (item > max)
                    max = item;
            }

            Console.WriteLine($"{sum - max} {sum - min}");
        }
        public void Find_O_n_Using_Two_For_Loops(int[] arr)
        {
            //Complexity O(n) + O(n). Finally O(n)
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            long min = arr[0];
            long max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
                if (arr[i] > max)
                    max = arr[i];
            }
            Console.WriteLine($"{sum - max} {sum - min}");
        }
        public void Find_O_n_Using_Two_ForEach_Loops(int[] arr)
        {
            //Complexity O(n) + O(n). Finally O(n)
            long sum = 0;
            foreach(var item in arr)
                sum += item;

            long min = arr[0];
            long max = arr[0];
            foreach (var item in arr)
            {
                if (item < min)
                    min = item;
                if (item > max)
                    max = item;
            }

            Console.WriteLine($"{sum - max} {sum - min}");
        }
        public void Find_O_n_Using_One_For(int[] arr)
        {
            //Comnplexity O(n): This is the most efficient solution
            long min = arr[0];
            long max = arr[0];
            long sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"{sum - max} {sum - min}");
        }
        public void Find_O_n_Using_One_ForEach(int[] arr)
        {
            //Comnplexity O(n): This is the most efficient solution but for offer more performance than foreach
            long min = arr[0];
            long max = arr[0];
            long sum = 0;

            foreach(var item in arr)
            {
                sum += item;
                if (item > max)
                    max = item;
                if (item < min)
                    min = item;
            }
            Console.WriteLine($"{sum - max} {sum - min}");
        }
    }
}
