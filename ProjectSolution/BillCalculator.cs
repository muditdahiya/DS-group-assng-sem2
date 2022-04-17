namespace ProjectSolution
{
    /// <summary>
    /// Context class for calculating bill amount
    /// </summary>
    internal class BillCalculator
    {
        private ICalculate strategy;

        /// <summary>
        /// Method to set the strategy for the calculator
        /// </summary>
        /// <param name="strategy">An instance of type <see cref="ICalculate"/> </param>
        public void SetStrategy(ICalculate strategy)
        {
            if (strategy == null)
            {
                throw new InvalidOperationException("Strategy is null and cannot perform operation");
            }

            this.strategy = strategy;
        }

        /// <summary>
        /// Method to perfrom calculation as per the set strategy
        /// </summary>
        /// <param name="order">Order object.</param>
        public double Calculate()
        {
            if(strategy == null)
            {
                throw new InvalidOperationException("Strategy is null and cannot perform operation");
            }

            strategy.DoAlgorithm();

            return strategy.GetResult();
        }
    }
}
