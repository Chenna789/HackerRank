using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Staircase
{
    class StairCase
    {
        public void Solve_O_n2(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)//or for(int j = i; j < n; j++)
                    Console.Write(" ");

                for (int k = 1; k <= i; k++)
                    Console.Write("#");
                Console.WriteLine();
            }
        }
        public void Solve_Using_Two_For_Loops(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for(int j = i; j < n; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(new string('#', i));
            }
        }
        public void Solve_Using_One_For_Loops(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                //Console.Write(new string(' ', n - i));
                //Console.WriteLine(new string('#', i));
                               //OR
                Console.WriteLine(new string(' ', n - i) + new string('#', i));
            }
        }
        public void Solve_Using_PadLeft(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(new string('#', i).PadLeft(n, ' '));
            }
        }
        public void Solve_Using_String_Format(int n)
        {
            var message = string.Empty;
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("{0, "+n+"}", message += "#");
                //Console.WriteLine("{0, 4}", message += "#"); print a string with 4 bytes and append message
                //Suppose of the string is of length 1 and count is of 4, it appends 3 spaces in the begining
                //Suppose of the string is of length 2 and count is of 4, it appends 2 spaces in the begining
            }
        }
    }
}
