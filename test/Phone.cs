using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Phone : Product
    {
        public override double computeTax()
        {
            return Price * 10 / 100;  
        }

        
    }
}
