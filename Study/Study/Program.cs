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
            int[] testScore = {1,2,3,4,5 };
            int i = 0;
            while(i < testScore.Length)
            {
                Console.WriteLine(testScore[i]);
                i++;
            }
            Console.WriteLine("\n");
            for(int j = 0; j < testScore.Length; j++)
            {
                Console.WriteLine(testScore[j]);
            }
            Console.WriteLine("\n");
            foreach (var item in testScore)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
        }
    }
}
