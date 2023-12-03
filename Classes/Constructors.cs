using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{

    internal class Constructors
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Gülben");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order  = new Order();
            customer.Orders.Add(order); 
        }
    }
}
