//keeps track of occupied, order, bill, customer

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
        }


    }
}