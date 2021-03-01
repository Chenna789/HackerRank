using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Compare_Tripplet
{
    class TrippletComparison
    {
        public List<int> CompareTripplets(List<int> a, List<int> b)
        {
            List<int> resultList = new List<int>() { 0, 0 };

            for(int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                    resultList[0]++;
                else if (a[i] < b[i])
                    resultList[1]++;
            }

            return resultList;
        }

        //Given input contains exactly 3 elements in array
        public List<int> CompareTripplets_Static(List<int> a, List<int> b)
        {
            List<int> resultList = new List<int>() { 0, 0 };

            resultList[0] = (a[0] > b[0] ? 1 : 0) + (a[1] > b[1] ? 1 : 0) + (a[2] > b[2] ? 1 : 0);
            resultList[1] = (a[0] < b[0] ? 1 : 0) + (a[1] < b[1] ? 1 : 0) + (a[2] < b[2] ? 1 : 0);

            return resultList;
        }
    }
}
