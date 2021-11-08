using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    interface IAccount
    {
        void displayAccData();
        void getAccData(int type);
    }
}
