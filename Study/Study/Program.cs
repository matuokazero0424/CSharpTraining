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
               switch(j)
                {
                    case 0: 
                        Console.WriteLine("国語の点数は{0}点です",testScore[j]); 
                        break;
                    case 1:
                        Console.WriteLine("社会の点数は{0}点です", testScore[j]);
                        break;
                    case 2:
                        Console.WriteLine("数学の点数は{0}点です", testScore[j]);
                        break;
                    case 3:
                        Console.WriteLine("理科の点数は{0}点です", testScore[j]);
                        break;
                    case 4:
                        Console.WriteLine("英語の点数は{0}点です", testScore[j]);
                        break;
                }
            }
        }
    }
}
