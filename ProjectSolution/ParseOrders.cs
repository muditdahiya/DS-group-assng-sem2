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
            Console.WriteLine("Item||Quantity||PerUnitPrice||Total");
            foreach (var item in orderItems)
            {
                Console.WriteLine($"{item.Key.name}||{item.Value}||{item.Key.price}||{item.Key.price * item.Value}");
            }
        }
    }
}
