using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    class SavingsAcc:account
    {
        public virtual string Stop_Payment()
        {
            return ("Your Current Savings Account transaction is freezed");
        }
        public virtual string Open()
        {
            return ("Your Savings Account is now active");
        }
        public virtual string Close()
        {
            return ("Your Savings Account is now Closed");
        }
    }
}
