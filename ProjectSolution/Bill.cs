//use facade here

namespace ProjectSolution
{
    /// <summary>
    /// Facade class for the bill calculator
    /// </summary>
    internal class Bill
    {
        private readonly Order order;
        private readonly Customer customer;
        private BillCalculator billCalculator;
        private ParseOrders orderParser;

        public Bill(Order order, Customer Customer)
        {
            this.order = order;
            customer = Customer;
            billCalculator = new BillCalculator();
            orderParser = new ParseOrders(order);
        }

        public void GenerateBill()
        {
            // 1. Display the contents of the order and the itemized price calculation
            orderParser.DisplayBill();
            Console.WriteLine("***********************************");

            //2. Calcuate Total Amount
            billCalculator.SetStrategy(new SumBillAmountStrategy(order));
            double totalBillAmount = billCalculator.Calculate();
            Console.WriteLine($"Total Amount: {totalBillAmount}");
            Console.WriteLine("***********************************");

            //3. Apply Tax
            billCalculator.SetStrategy(new ApplyTaxStrategy(totalBillAmount, 0.13));
            totalBillAmount = billCalculator.Calculate();
            Console.WriteLine($"Total Amount After Applying Taxes: {totalBillAmount}");
            Console.WriteLine("***********************************");

            //4. Apply Discount
            billCalculator.SetStrategy(new ApplyDiscountStrategy(totalBillAmount, customer));
            totalBillAmount = billCalculator.Calculate();
            Console.WriteLine($"Total Amount After Applying Discounts: {totalBillAmount}");
            Console.WriteLine("***********************************");
        }
    }
}
