using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Diagonal_Difference
{
    class DiagonalDifference
    {
        public int FindDifference_Using_Two_For_Loops(List<List<int>> arr)
        {
            int rightDiagonalSum = 0;
            for(int i = 0; i < arr.Count; i++)
            {
                rightDiagonalSum += arr[i][i];
            }
            int leftDiagonalSum = 0;
            int k = arr[0].Count - 1;
            for(int i = 0; i < arr.Count; i++)
            {
                leftDiagonalSum += arr[i][k];
                k--;
            }
            return Math.Abs(rightDiagonalSum - leftDiagonalSum);
        }
        public int FindDifference_Using_One_ForEach_Loop(List<List<int>> arr)
        {
            int rightDiagonalSum = 0, leftDiagonalSum = 0;
            int i = 0, j = arr[0].Count - 1;

            foreach(List<int> item in arr)
            {
                rightDiagonalSum += item[i];
                i++;
                leftDiagonalSum += item[j];
                j--;
            }
            return Math.Abs(rightDiagonalSum - leftDiagonalSum);
        }
        public int FindDifference_Using_One_For_Loop(List<List<int>> arr)
        {
            int rightDiagonalSum = 0, leftDiagonalSum = 0;
            int i = 0, j = arr[0].Count - 1;

            for(int k = 0; k < arr.Count; k++)
            {
                rightDiagonalSum += arr[k][i];
                i++;
                leftDiagonalSum += arr[k][j];
                j--;
            }
            return Math.Abs(rightDiagonalSum - leftDiagonalSum);
        }
        public int FindDifference_Using_One_For_Loop2(List<List<int>> arr)
        {
            int sum = 0;

            for(int i = 0; i < arr[0].Count; i++)
            {
                sum += arr[i][i] - arr[i][arr[i].Count - 1 -i];
            }
            return Math.Abs(sum);
        }
    }
}
