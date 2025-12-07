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
            int beforeWeight = 45;
            int afterWeight;
            int potetoCalorie = 10;
            
            afterWeight = beforeWeight + potetoCalorie;
            Console.WriteLine("ジオくんの体重は{0}kgになっちゃった",afterWeight);
        }
    }
}
