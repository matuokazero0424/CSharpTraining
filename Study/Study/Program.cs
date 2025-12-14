using System;
using System.CodeDom;
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
            NoLoseFight();
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
        private static void CheckAdult()
        {
            Console.WriteLine("あなたは18歳以上ですか？あなたの年齢を入力してください。");
            int age = int.Parse(Console.ReadLine());
            string message = (age >= 18) ? "おめでとうございます。暖簾をくぐれます" : "まだ、暖簾をくぐれません。";
            Console.WriteLine(message);
        }

        private static void CheckAdult2()
        {
            Console.WriteLine("あなたは18歳以上ですか？あなたの年齢を入力してください。");
            int age = int.Parse(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("おめでとう、暖簾をくぐれます。");
            }
            else
            {
                Console.WriteLine("まだ、暖簾をくぐれません。");
            }
        }

        private static void NoLoseFight()
        {
            const string Ykun = "盛っている!!こんなにあるわけない!!";
            const string Zkun = "盛っていない!!これがナチュラルな姿!!";
            Console.WriteLine("Ykun.このイラストは{0}",Ykun );
            Console.WriteLine("Zkun.いやいや{0}",Zkun);
            //string kurakae = "確かにそうか";
            
        }

    }
}
