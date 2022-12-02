using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int number1 = 10;
            Console.WriteLine("number1 is {0}", number1);
            //int Min sınırı -2147483648   Max sınırı +2147483647
            long number2 = 6656157896265894875;
            Console.WriteLine("number2 is {0}", number2);
            short number3 = 516;
            Console.WriteLine("number3 is {0}", number3);
            byte number4 = 255;
            Console.WriteLine("number4 is {0}", number4);
            bool condition = false;
            char character = 'A';
            Console.WriteLine("Character is {0}", (int)character);
            double number5 = 145;
            Console.WriteLine("number5 is  {0}", number5);
            double number6 = 157.5;
            Console.WriteLine("number6 is {0}", number6);
            decimal number7= 54.5348m;
            Console.WriteLine("number7 is {0}", number7);
            decimal number8 = 5478.54M;
            Console.WriteLine("number8 is {0}", number8);
            Console.WriteLine("month is {0}", Months.haziran);
            Console.WriteLine((int)Months.mart);
            Console.WriteLine((int)Months.ekim);
            Console.WriteLine((int)Months.nisan);
            var number9 = 41;
            Console.WriteLine(number9);
            number9 = 'G';
            Console.WriteLine("number9 is  {0}",number9);
            Console.ReadLine();
        }
        enum Months
        {
            ocak,şubat,mart=18,nisan,mayıs,haziran,temmuz,ağustos,eylül=21,ekim,kasım,aralık
        }
    }
}
