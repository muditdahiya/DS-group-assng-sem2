using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    class Kitchen
    {
        //member variable
        Queue<Order> orders;

        public Kitchen()
        {
            //creating a queue
            orders = new Queue<Order>();  
        }
        //Order item is added to queue
        public void AddOrder(Order item)
        {
            orders.Enqueue(item);
            Console.WriteLine("Order received, coming right up");
        }

        //Order item is removed from queue
        public void CookOrder()
        {
            orders.Dequeue();
            Console.WriteLine("Order's ready! Bon Appetit!");
        }
    }
}
