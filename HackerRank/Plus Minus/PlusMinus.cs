using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Plus_Minus
{
    class PlusMinusSolution
    {
        public void PlusMinus_Using_For(int[] arr)
        {
            int n = arr.Length;
            double positive = 0, negative = 0, zeros = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    positive++;
                else if (arr[i] < 0)
                    negative++;
                else
                    zeros++;
            }
            Console.WriteLine((positive / n).ToString("N6"));
            Console.WriteLine((negative / n).ToString("N6"));
            Console.WriteLine((zeros / n).ToString("N6"));
        }
        public void PlusMinus_Using_Foreach(int[] arr)
        {
            int n = arr.Length;
            double positive = 0;
            double negative = 0;
            double zeros = 0;
            foreach(var item in arr)
            {
                if (item > 0)
                    positive++;
                else if (item < 0)
                    negative++;
                else
                    zeros++;
            }
            Console.WriteLine(string.Format("{0:0.000000}", positive / n));
            Console.WriteLine(string.Format("{0:0.000000}", negative / n));
            Console.WriteLine(string.Format("{0:0.000000}", zeros / n));
        }
        //This is not the efficient way as it using foreach internally for each count
        public void PlusMinus_Using_Linq(int[] arr)
        {
            Console.WriteLine(string.Format("{0:N6}", (double)arr.Count(x => x > 0) / arr.Length));
            Console.WriteLine(string.Format("{0:N6}", (double)arr.Count(x => x < 0) / arr.Length));
            Console.WriteLine(string.Format("{0:N6}", (double)arr.Count(x => x == 0) / arr.Length));
        }
    }
}
