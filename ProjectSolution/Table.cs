//keeps track of occupied, order, bill, customer
//table is observing restaurant

namespace ProjectSolution
{
    class Table
    {
        public int Number { get; }
        public Customer Customer { get; set; }
        public Order Order { get; set; }
        public Bill Bill { get; set; }
        public bool IsOccupied { get; set; }

        public Table(int n)
        {
            Number = n;
            Order = new Order();
        }

        //checkout method that empties table, generates bill, resets order
        public void Checkout ()
        {
            IsOccupied = false;
            //this refers to the table object we are currently inside
            Bill = new Bill(Order, this);
            Bill.GenerateBill();
            Order.Clear();
        }

        //to string to display table inforamtion
        public override string ToString()
        {
            ParseOrders parser = new ParseOrders(Order);
            string result = $"Table number: {Number}\n";
            result += $"Occupied: {IsOccupied}\n";
            if (IsOccupied)
            {
                result += $"Order: \n{parser.DisplayBill()}\n";
            }
            return result;
        }
    }
}