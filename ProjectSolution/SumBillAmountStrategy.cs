namespace ProjectSolution
{
    /// <summary>
    /// Strategy to calculate total bill amount.
    /// </summary>
    internal class SumBillAmountStrategy : ICalculate
    {
        private double totalBillAmount;
        private Order order;

        public SumBillAmountStrategy(Order  order)
        {
            this.order = order;
        }

        /// <inheritdoc/>
        public void DoAlgorithm()
        {
            var menuItems = order.MenuItems;

            foreach (var item in menuItems)
            {
                totalBillAmount += item.Key.price;
            }
        }

        /// <inheritdoc/>
        public double GetResult()
        {
            return totalBillAmount;
        }
    }
}
