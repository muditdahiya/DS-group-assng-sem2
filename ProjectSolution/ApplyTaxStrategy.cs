namespace ProjectSolution
{
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
            totalAmount = totalBillAmount + (totalBillAmount * taxPercentage);
        }

        public double GetResult()
        {
            return totalAmount;
        }
    }
}
