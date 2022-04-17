//keeps track of occupied, order, bill, customer

namespace ProjectSolution
{
    class Table
    {
        int Number { get; }
        Customer Customer { get; set; }
        Order Order { get; set; }
        Bill Bill { get; set; }
        bool IsOccupied { get; set; }

        public Table(int n)
        {
            Number = n;
        }


    }
}