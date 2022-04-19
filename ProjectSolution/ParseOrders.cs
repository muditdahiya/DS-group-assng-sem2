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
        public string DisplayBill()
        {
            var orderItems = order.MenuItems;
            string result = "Item    || Quantity || PerUnitPrice || Total\n";

            foreach (var item in orderItems)
            {
                result += $"{item.Key.name.PadRight(8)}|| " +
                    $"{item.Value.ToString().PadRight(9)}|| " +
                    $"{item.Key.price.ToString().PadRight(13)}|| " +
                    $"{(item.Key.price * item.Value).ToString().PadRight(8)}\n";

            }

            return result;
        }
    }
}
