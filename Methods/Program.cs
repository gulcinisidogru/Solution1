using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Add();
            //int sonuc = Add1(5,10);
            //Console.WriteLine(sonuc);

            int islem = Add1(26, 2);
            Console.WriteLine(islem);

            Console.ReadLine();

        }

        //static void Add()
        //{
        //    Console.WriteLine("eklendi!");

        //}

        //static int Add1(int number1, int number2)
        //{
        //    int sonuc = number1 + number2;

        //    return sonuc;

        //}



        static int Add1(int number1 = 5, int number2 = 16)
        {
            int islem = number1 + number2;
            return islem;
        }



    }
}
