using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Prince_Tiwari_Assignment1
{
    internal class Palindrome_Triangle_Pattern
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int count = i;
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {

                    Console.Write(count);
                    count--;
                }

                for (int m = 2; m <= i; m++)
                {
                    Console.Write(m);
                }
                Console.WriteLine();
            }
        }
    }
}