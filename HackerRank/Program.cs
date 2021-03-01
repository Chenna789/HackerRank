using HackerRank.Compare_Tripplet;
using HackerRank.Diagonal_Difference;
using HackerRank.Plus_Minus;
using HackerRank.Simple_Array_Sum;
using HackerRank.Min_Max_Sum;
using HackerRank.Staircase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using System.Reflection;

namespace HackerRank
{
    class Program
    {
        static void Main(String[] args)
        {
            //Read whole line and convert to array
            //String input = Console.ReadLine();
            //int[] arr1 = ConvertToIntArray_UsingFor(input);
            //int[] arr2 = ConvertToIntArray_UsingForEach(input);
            //int[] arr3 = ConvertToIntArray_UsingArrayForEach(input);

            //VeryBigSum veryBigSum = new VeryBigSum();
            //long[] arr = new long[] { 1000000001, 1000000002, 1000000003, 1000000004, 1000000005 };
            //Console.WriteLine(veryBigSum.CalculateSum_UsingFor(arr));
            //Console.WriteLine(veryBigSum.CalculateSum_UsingForEach(arr));
            //Console.WriteLine(veryBigSum.CalculateSum_UsingArrayForEach(arr));
            //Console.WriteLine(veryBigSum.CalculateSum_Using_Linq_Aggregate(arr));
            //Console.WriteLine(veryBigSum.CalculateSum_Using_Linq_IENumerable_Sum(arr));
            //TrippletComparison trippletComparison = new TrippletComparison();
            //Console.WriteLine(string.Join(" ", trippletComparison.CompareTripplets(new List<int>() { 17, 28, 30 }, new List<int>() { 99, 16, 8 })));
            //Console.WriteLine(string.Join(" ", trippletComparison.CompareTripplets_Static(new List<int>() { 17, 28, 30 }, new List<int>() { 99, 16, 8 })));
            //DiagonalDifference diagonalDifference = new DiagonalDifference();
            //List<List<int>> list = new List<List<int>>()
            //{
            //    new List<int>(){ 11, 2, 4},
            //    new List<int>(){ 4, 5, 6},
            //    new List<int>(){ 10, 8, -12},
            //};
            //Console.WriteLine(diagonalDifference.FindDifference_Using_Two_For_Loops(list));
            //Console.WriteLine(diagonalDifference.FindDifference_Using_One_For_Loop(list));
            //Console.WriteLine(diagonalDifference.FindDifference_Using_One_ForEach_Loop(list));
            //Console.WriteLine(diagonalDifference.FindDifference_Using_One_For_Loop2(list));

            //PlusMinusSolution plusMinusSolution = new PlusMinusSolution();
            //plusMinusSolution.PlusMinus_Using_For(new int[] { -4, 3, -9, 0, 4, 1 });
            //plusMinusSolution.PlusMinus_Using_Foreach(new int[] { -4, 3, -9, 0, 4, 1 });
            //plusMinusSolution.PlusMinus_Using_Linq(new int[] { -4, 3, -9, 0, 4, 1 });
            //StairCase stairCase = new StairCase();
            //stairCase.Solve_Using_PadLeft(4);
            //Console.WriteLine("*************");
            //stairCase.Solve_O_n2(4);
            //Console.WriteLine("*************");
            //stairCase.Solve_Using_String_Format(4);
            //Console.WriteLine("*************");
            //stairCase.Solve_Using_Two_For_Loops(4);
            //Console.WriteLine("*************");
            //stairCase.Solve_Using_One_For_Loops(4);
            //MinMaxSum minMaxSum = new MinMaxSum();
            //minMaxSum.Find_O_n2(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_Static(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_Using_Sort(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_Using_Sort_Static(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_Using_Sum_And_Max_Min(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_O_n_Using_Three_ForEach_Loops(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_O_n_Using_Three_For_Loops(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_O_n_Using_Two_ForEach_Loops(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_O_n_Using_Two_For_Loops(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_O_n_Using_One_For(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //minMaxSum.Find_O_n_Using_One_ForEach(new int[] { 140638725, 436257910, 953274816, 734065819, 362748590 });
            //string encodedString = "c2FnZGZqY2doYQ==";
            //byte[] data = Convert.FromBase64String(encodedString);
            //string decodedString = Encoding.UTF8.GetString(data);
            //Console.WriteLine(decodedString);
            File.Delete(@"c:\temp\Rajesh123334.txt");
            string ret = StartProcess(@"get --api-key-grant-policy-id {0} --vkm {1} --secret-name {2} --stdout --utf-8", out bool isSuccess);
        }
        static int[] ConvertToIntArray_UsingFor(String s)
        {
            String[] strArray = s.Split();
            int[] intArray = new int[strArray.Length];

            for(int i = 0; i < strArray.Length; i++)
            {
                intArray[i] = Convert.ToInt32(strArray[i]);
            }

            return intArray;
        }
        static int[] ConvertToIntArray_UsingForEach(String s)
        {
            String[] strArray = s.Split();
            int[] intArray = new int[strArray.Length];

            int i = 0;
            foreach(var item in strArray)
            {
                intArray[i] = Convert.ToInt32(item);
                i++;
            }

            return intArray;
        }
        static int[] ConvertToIntArray_UsingArrayForEach(String s)
        {
            return Array.ConvertAll(s.Split(), x => Convert.ToInt32(x));
        }

        public static string StartProcess(string strCmdText, out bool isSuccess)
        {
            try
            {
                System.Diagnostics.Debugger.Launch();
                using (System.Diagnostics.Process process = new System.Diagnostics.Process())
                {
                    string codeBase = Assembly.GetCallingAssembly().CodeBase;
                    UriBuilder uri = new UriBuilder(codeBase);
                    string path = Uri.UnescapeDataString(uri.Path);
                    codeBase = System.Reflection.Assembly.GetExecutingAssembly().Location;
                    uri = new UriBuilder(codeBase);
                    path = Uri.UnescapeDataString(uri.Path);
                    process.StartInfo.FileName = @"c:\www\FastPath\bin\stash.exe";
                    process.StartInfo.Arguments = strCmdText;
                    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.UseShellExecute = false; // to redirect output to stdout
                    //process.StartInfo.WorkingDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase);
                    process.StartInfo.WorkingDirectory = @"c:\www\FastPath\bin";
                    string path1 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    process.Start();
                    process.WaitForExit();
                    isSuccess = process.ExitCode == 0;
                    if (isSuccess)
                        return process.StandardOutput.ReadLine();
                    else
                        return process.StandardError.ReadLine();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
