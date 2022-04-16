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
        private readonly Dictionary<int, Order> orders;

        public ParseOrders(Dictionary<int, Order> orders)
        {
            this.orders = orders;
        }

        /// <summary>
        /// Method to generate bill
        /// </summary>
        public void GenerateBill()
        {

        }
    }
}
