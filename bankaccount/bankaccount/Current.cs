using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    class Current:account
    {
        public virtual string Stop_Payment()
        {
            return ("Your Current Account transaction is freezed");
        }
        public virtual string Open()
        {
            return ("Your Current Account is now active");
        }
        public virtual string Close()
        {
            return ("Your Current Account is now Closed");
        }
    }
}
