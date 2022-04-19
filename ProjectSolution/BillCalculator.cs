namespace ProjectSolution
{
    // Context class for calculating bill amount
    internal class BillCalculator
    {
        private ICalculate strategy;

        // Method to set the strategy for the calculator
        public void SetStrategy(ICalculate strategy)
        {
            if (strategy == null)
            {
                throw new InvalidOperationException("Strategy is null and cannot perform operation");
            }

            this.strategy = strategy;
        }

        // Method to perfrom calculation as per the set strategy
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
