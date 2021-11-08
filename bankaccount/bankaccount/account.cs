using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccount
{
    class account
    {
        public long Account_Number { get; set; }
        public string Customer_Name { get; set; }
        public double Balance { get; set; }
        public double Min_Balance { get; set; }
        public double Rate_of_Interest { get; set; }
        public void getAccInfo()
        {
            Console.WriteLine("Enter the Account number, Customer name, Balance");
            Account_Number = Convert.ToInt64(Console.ReadLine());
            Customer_Name = Console.ReadLine();
            Balance = Convert.ToDouble(Console.ReadLine());
        }
        public long getAccNo()
        {
            return Account_Number;
        }
        public string getCustName()
        {
            return Customer_Name;
        }
        public double getbal()
        {
            return Balance;
        }
        public string Withdraw( double amount)
        {
            return ("An amount withdrawn is: "+amount);
        }
        public string Deposit(double amount)
        {
            return ("An amount deposit is: " + amount);
        }
        public virtual string Open(string str1, string str2)
        {
            return ("Your " + str1 + " " + str2 + " Account is now active");
        }
        public virtual string Close(string str1, string str2)
        {
            return ("Your "+str1+" "+str2+" Account is now Closed");
        }
        public virtual string Stop_Payment()
        {
            return ("Your Current transaction is freezed");
        }
        public void getminbal_rate()
        {
            Console.WriteLine("The minimum Balance required is is: "+Min_Balance);
            Console.WriteLine("The rate of interest applicable is: "+Rate_of_Interest);
        }
    }
}
