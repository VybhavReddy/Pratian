using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    class PersonalAcc:IAccount
    {
        public string Nominee { get; set; }
        public string Introducer_Name { get; set; }
        public string Occupation { get; set; }
        account accountobj = null;
        double withdrawamt, depositamt;
        string acctype="";
        public void getAccData(int type)
        {
            if (type == 1)
            {
                accountobj = new SavingsAcc();
                accountobj.Min_Balance = 2000;
                accountobj.Rate_of_Interest = 5;
                acctype = "Savings";
            }
            else if (type == 2)
            {
                accountobj = new Current();
                accountobj.Min_Balance = 10000;
                accountobj.Rate_of_Interest = 3;
                acctype = "Current";
            }
            else if (type == 3)
            {
                accountobj = new OverDraftAcc();
                accountobj.Min_Balance = 2000;
                accountobj.Rate_of_Interest = 4;
                acctype = "Over-Draft";
            }
            Console.WriteLine("Enter the Nominee, Introducer Name, Occupation");
            Nominee = Console.ReadLine();
            Introducer_Name = Console.ReadLine();
            Occupation = Console.ReadLine();
            accountobj.getAccInfo();
            Console.WriteLine("Enter the deposit amount");
            depositamt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Withdraw amount");
            withdrawamt = Convert.ToDouble(Console.ReadLine());
        }
        public void displayAccData()
        {
            Console.WriteLine();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Account number: "+accountobj.getAccNo());
            Console.WriteLine("Customer Name: "+accountobj.getCustName());
            Console.WriteLine(accountobj.Withdraw(withdrawamt));
            Console.WriteLine(accountobj.Deposit(depositamt));
            Console.WriteLine("Account Balance is: " + (accountobj.getbal() - withdrawamt + depositamt));
            Console.WriteLine(accountobj.Open("Personal",acctype));
            Console.WriteLine(accountobj.Close("Personal", acctype));
            accountobj.getminbal_rate();
            Console.WriteLine(accountobj.Stop_Payment());
        }
    }
}
