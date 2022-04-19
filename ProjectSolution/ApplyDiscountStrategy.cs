using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    // Strategy class to apply discount.
    internal class ApplyDiscountStrategy : ICalculate
    {
        private double finalBillAmount;
        private double totalBillAmount;
        private Customer customer;
        public ApplyDiscountStrategy(double totalBillAmount, Customer customer)
        {
            this.customer = customer;
            this.totalBillAmount = totalBillAmount;
        }

        public void DoAlgorithm()
        {
            var discountPercentage = customer.GetDiscount(); // Get the discount percentage
            finalBillAmount = totalBillAmount - (totalBillAmount * discountPercentage); // Apply discounts
        }
        public double GetResult()
        {
            return finalBillAmount;
        }
    }
}
