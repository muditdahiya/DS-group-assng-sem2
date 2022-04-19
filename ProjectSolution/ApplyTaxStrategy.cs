namespace ProjectSolution
{
    // Apply tax calculation
    internal class ApplyTaxStrategy : ICalculate
    {
        private readonly double totalBillAmount;
        private readonly double taxPercentage;
        private double totalAmount;
        public ApplyTaxStrategy(double totalBillAmount, double taxPercentage)
        {
            this.totalBillAmount = totalBillAmount;
            this.taxPercentage = taxPercentage;
        }
        public void DoAlgorithm()
        {
            totalAmount = totalBillAmount + (totalBillAmount * taxPercentage); // Add Tax percentage to total bill amount
        }

        public double GetResult()
        {
            return totalAmount;
        }
    }
}
