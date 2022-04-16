//CustomerFactory object should be created in Bill to decide discount amount

namespace ProjectSolution
{
    class CustomerFactory
    {
        public Customer GetCustomer(int age, bool isStudent)
        {   //if statements to check customer type and redeemable discounts
            if (isStudent)
            {
                return new CustomerTypeStudent();
                //instance to return CustomerTypeStudent
            }
            //Verifying age brackets 
            else if (age < 12)
            {
                return new CustomerTypeKid();
                //instance to return CustomerTypeKid
            }
            else if (age >= 60)
            {
                return new CustomerTypeSenior();
                //instance to return CustomerTypeSenior
            }
            return new CustomerTypeRegular();
        }

    }
}
