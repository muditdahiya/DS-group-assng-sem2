using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSolution
{ //Class implements Customer
    class CustomerTypeRegular : Customer
    {
        //GetDiscount returns value of discount %
        public double GetDiscount()
        { //Regular customers = 0% discount
          //No discounts executed
            return 0.00;
        }
    }
}
