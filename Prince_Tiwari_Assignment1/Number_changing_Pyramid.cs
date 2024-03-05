using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prince_Tiwari_Assignment1
{
    internal class Number_changing_Pyramid
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(count++);
                }
                Console.WriteLine();
            }
        }
    }
}