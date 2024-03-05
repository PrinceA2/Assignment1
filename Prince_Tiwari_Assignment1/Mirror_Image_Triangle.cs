using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prince_Tiwari_Assignment1
{
    internal class Mirror_Image_Triangle
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k <= n; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }

            for (int i = n; i > 1; i--)
            {
                for (int j = 2; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i - 1; k <= n; k++)
                {
                    Console.Write(k + " ");
                }
                Console.WriteLine();
            }
        }
    }
}