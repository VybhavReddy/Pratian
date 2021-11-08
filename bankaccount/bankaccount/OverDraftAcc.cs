using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    class OverDraftAcc:account
    {
        public virtual string Stop_Payment()
        {
            return ("Your Over draft account transaction is freezed");
        }
        public virtual string Open()
        {
            return ("Your draft account Account is now active");
        }
        public virtual string Close()
        {
            return ("Your draft account Account is now Closed");
        }

    }
}
