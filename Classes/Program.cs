using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            // alttaki sınıfın bir örneğini oluşturmuş oldum yani ben burda 
            // örnekte camel case ,sınıfta pascal case

            customerManager.Add();
            customerManager.Update();

          




            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated");

        }


    }



}
