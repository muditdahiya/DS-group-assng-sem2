namespace ProjectSolution
{
    // Strategy to calculate total bill amount.
    internal class SumBillAmountStrategy : ICalculate
    {
        private double totalBillAmount;
        private Order order;

        public SumBillAmountStrategy(Order  order)
        {
            this.order = order;
        }

        public void DoAlgorithm()
        {
            var menuItems = order.MenuItems;

            foreach (var item in menuItems)
            {
                totalBillAmount += (item.Key.price * item.Value); // Add total values for all the items
            }
        }

        public double GetResult()
        {
            return totalBillAmount;
        }
    }
}
