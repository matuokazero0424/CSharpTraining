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
            float realHeight = 169.5f;
            int scamHeight = (int)realHeight;
            Console.WriteLine("正確な身長は{0}です",realHeight);
            Console.WriteLine("ざっくり身長は{0}です",scamHeight); 

        }
    }
}
