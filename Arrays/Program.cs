using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] bölgeler = new string[3, 3]
            {
                {"istanbul","adana","mersin" },
                {"ayşe","fatma","hayriye" },
                {"haydi","çiftetelliye","ee" }


            };

            for(int i = 0; i <= bölgeler.GetUpperBound(0); i++)
            {
                for(int j=0; j<=bölgeler.GetUpperBound(0); j++)
                {
                    Console.WriteLine(bölgeler[i,j]);
                }Console.WriteLine("****************");
            }
            
            Console.ReadLine();
        }
               
    }
}
