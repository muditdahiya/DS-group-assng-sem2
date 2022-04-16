using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{    //Class implements Customer
    class CustomerTypeKid : Customer
    {  //GetDiscount returns value of discount %
        public double GetDiscount()
        { //Kids = 5% discount
          //0.05 gets multiplied from total sum and that gets deducted from total bill amount 
            return 0.05;
        }
    }
}
