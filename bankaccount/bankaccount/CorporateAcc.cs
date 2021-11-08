using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    class CorporateAcc:IAccount
    {
        public string Company_Type { get; set; }
        public string Authorized_Signatory{ get; set; }
        public string Date_of_Incorporation { get; set; }
        public string Nature_of_Business { get; set; }
        string acctype = "";
        double withdrawamt, depositamt;
        account accountobj = null;
        public void getAccData(int type)
        {
            if (type == 1)
            {
                accountobj = new SavingsAcc();
                accountobj.Min_Balance = 0;
                accountobj.Rate_of_Interest = 4.5;
                acctype = "Savings";
            }
            else if (type == 2)
            {
                accountobj = new Current();
                accountobj.Min_Balance = 10000;
                accountobj.Rate_of_Interest = 2.5;
                acctype = "Current";
            }
            else if (type == 3)
            {
                accountobj = new OverDraftAcc();
                accountobj.Min_Balance = 1000;
                accountobj.Rate_of_Interest = 3.5;
                acctype = "Over-Draft";
            }
            Console.WriteLine("Enter Company Type, Authorized Signatory, Date of Incorporation, Nature of Business");
            Company_Type = Console.ReadLine();
            Authorized_Signatory = Console.ReadLine();
            Date_of_Incorporation = Console.ReadLine();
            Nature_of_Business = Console.ReadLine();
            accountobj.getAccInfo();
            Console.WriteLine("Enter the deposit amount");
            depositamt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Withdraw amount");
            withdrawamt = Convert.ToDouble(Console.ReadLine());
        }
        public void displayAccData()
        {
            Console.WriteLine("Account number: " + accountobj.getAccNo());
            Console.WriteLine("Customer Name: " + accountobj.getCustName());
            
            Console.WriteLine(accountobj.Withdraw(withdrawamt));
            Console.WriteLine(accountobj.Deposit(depositamt));
            Console.WriteLine("Account Balance is: " + (accountobj.getbal() - withdrawamt + depositamt));

            Console.WriteLine(accountobj.Open("Corporate", acctype));
            Console.WriteLine(accountobj.Close("Corporate", acctype));
            accountobj.getminbal_rate();
            Console.WriteLine(accountobj.Stop_Payment());
        }
    }
}
