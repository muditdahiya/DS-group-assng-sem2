using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    /// <summary>
    /// Class to parse and generate bill
    /// </summary>
    internal class ParseOrders
    {
        private readonly Order order;

        public ParseOrders(Order order)
        {
            this.order = order;
        }

        /// <summary>
        /// Method to generate bill
        /// </summary>
        public void DisplayBill()
        {
            var orderItems = order.MenuItems;
            Console.WriteLine("Item\tQuantity\tPerUnitPrice\tTotal");
            foreach (var item in orderItems)
            {
                Console.WriteLine($"{item.Key.name}\t{item.Value}\t{item.Key.price}\t{item.Key.price * item.Value}");
            }
        }
    }
}
