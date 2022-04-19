using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    // Class to parse and generate bill
    internal class ParseOrders
    {
        private readonly Order order;

        public ParseOrders(Order order)
        {
            this.order = order;
        }

        // Method to generate bill
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
