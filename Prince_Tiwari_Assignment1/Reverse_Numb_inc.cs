using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prince_Tiwari_Assignment1
{
    internal class Reverse_Numb_inc
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}