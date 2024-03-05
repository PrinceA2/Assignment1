using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prince_Tiwari_Assignment1
{
    internal class Zero_One_Triangle_Pattern
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int x = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(x + " ");
                    if (x == 1)
                    {
                        x = x - 1;
                    }
                    else
                    {
                        x = x + 1;
                    }

                }
                Console.WriteLine();
            }
        }
    }
}