using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    class Book : Product
    {
        public override double computeTax()
        {
            return Price * 5 / 100;    
        }
    }
}
