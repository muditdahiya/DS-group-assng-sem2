namespace ProjectSolution
{
    /// <summary>
    /// Strategy to calculate total bill amount.
    /// </summary>
    internal class SumBillAmountStrategy : ICalculate
    {
        private double totalBillAmount;
        private Dictionary<int, Order> orders;

        public SumBillAmountStrategy(Dictionary<int, Order>  orders)
        {
            this.orders = orders;
        }

        /// <inheritdoc/>
        public void DoAlgorithm()
        {
            foreach (var order in orders)
            {
                //totalBillAmount += order.Amount;
            }

        }

        /// <inheritdoc/>
        public double GetResult()
        {
            return totalBillAmount;
        }
    }
}
