using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{
    class CustomerTypeStudent : Customer
    {
        //GetDiscount returns value of discount %
        public double GetDiscount()
        { //Students = 10% discount
          //0.10 gets multiplied from total sum and that gets deducted from total bill amount 
            return 0.10;
        }
    }
}
