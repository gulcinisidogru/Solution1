using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = -95;
            //if (number == 10)
            //{
            //    Console.WriteLine("number is 10");
            //}
            //else if (number == 20)
            //{
            //    Console.WriteLine("number is 20");
            //}

            //else
            //{
            //    Console.WriteLine("number is not 10 or 20");
            //}

            //Console.ReadLine();

            //switch (number)
            //{
            //    case 22:
            //        Console.WriteLine("number is 22");
            //        break;
            //    case 15:
            //        Console.WriteLine("number is 15");
            //        break;
            //    default:
            //        Console.WriteLine("number is not 22 or 15");
            //        break;
            //}


            if(number>=0 && number <= 100)
            {
                Console.WriteLine("0 la 100 arasında");
            }
            else if(number>100 && number <= 200)
            {
                Console.WriteLine("100 den büyük 200 e eşit ve küçük");
            }else if(number<0 || number > 200)
            {
                Console.WriteLine("FARKLI SAYI");
            }



            Console.ReadLine();


        }
    }
}
