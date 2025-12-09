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
            int 足される数 = 10;
            int 足す数 = 2;
            int 和;
            和 = 足される数 + 足す数;
            Console.WriteLine(和);
        }
        private static void SayFunc()
        {
            var word = Console.ReadLine();
            var num1 = int.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            Console.WriteLine(word);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }

        private static void IntroduceMyself()
        {
            Console.WriteLine("アナタの名前は？");
            var name = Console.ReadLine();
            Console.WriteLine("アナタの年齢は？");
            var age = int.Parse(Console.ReadLine());
            Console.Write("アナタは{0}で、年齢は{1}歳です",name, age);
        }
    }
}
