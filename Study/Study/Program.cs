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
            
        }

        private static void SumFunc()
        {
            int sumNumber = 0;
            for(int i = 0; i <= 10; i++)
            {
                sumNumber += i;
            }
            Console.WriteLine(sumNumber);
        }
    }
}
