using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{

    struct Point
    {
        public int x;
        public int y; 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Point
            {
                x = 10,
                y = 20
            };

            Console.WriteLine(p.x);
            Console.WriteLine(p.y);

        }
    }
}
