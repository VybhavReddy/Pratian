using System;

namespace bankaccount
{
    class Program
    {
        static void Main(string[] args)
        {
            int coprOrPersonal, accType;
            Console.WriteLine("Enter 1 for Corporate account or 2 for Personal Account");
            coprOrPersonal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 1 for Savings account or 2 for Current Account or 3 for OverDraft account");
            accType= Convert.ToInt32(Console.ReadLine());
            if(coprOrPersonal==1)
            {
                IAccount account = new CorporateAcc();
                account.getAccData(accType);
                account.displayAccData();
            }
            else if(coprOrPersonal==2)
            {
                IAccount account = new PersonalAcc();
                account.getAccData(accType);
                account.displayAccData();
            }
        }
    }
}
 