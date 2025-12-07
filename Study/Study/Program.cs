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
            float averageTestScore;
            int sumTestSocre;

            int japaneseTestScore = 40;
            int mathTestScore = 100;
            
            sumTestSocre = japaneseTestScore + mathTestScore;
            averageTestScore = sumTestSocre / 2;

            Console.WriteLine(japaneseTestScore);
            Console.WriteLine(mathTestScore);
            

        }
    }
}
