using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testScore = {100, 92, 71, 69, 55 };
            for(int j = 0; j < testScore.Length; j++)
            {
                if(testScore[j] % 2 == 0)
                {
                    Console.WriteLine("{0}は偶数です", testScore[j]);
                }
                else
                {
                    Console.WriteLine("{0}は奇数です", testScore[j]);
                }
            }
        }
    }
}
