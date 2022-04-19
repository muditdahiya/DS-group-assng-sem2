//use facade here

namespace ProjectSolution
{
    // Facade class for the bill calculator
    internal class Bill
    {
        private readonly Order order;
        private readonly Customer customer;
        private BillCalculator billCalculator;
        private ParseOrders orderParser;
        private Table table;

        public Bill(Table table)
        {
            this.order = table.Order;
            this.table = table;
            customer = table.Customer;
            billCalculator = new BillCalculator();
            orderParser = new ParseOrders(order);
        }

        // Method to generate bill
        public void GenerateBill()
        {
            Console.WriteLine("\nBill for table number " + table.Number);
            // 1. Display the contents of the order and the itemized price calculation
            Console.WriteLine(orderParser.DisplayBill());
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
