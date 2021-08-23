using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
   public class CurrentBakAccount:BankAcccount
    {
        public CurrentBakAccount(string accountownername,string accountnumber)
            :base(accountownername,accountnumber)
        {
            this.MinaccountBalance = 0;
            this.MaxDepositeAmount = 100000000m;
            InterestRate = .25m;




        }
        public override void Deposite(decimal amount)
        {
            AccountBalance = AccountBalance + amount;
            TransactionSummery = string.Format("{0}\n Deposite:{1}", TransactionSummery, amount);
        }

        public override void Withdraw(decimal amount)
        {
            if (AccountBalance - amount <= MinaccountBalance)
            {
                throw new Exception("You can not withdraw amount from your Current Account as Minimum Balance limit is reached")
                    
                    ;
        }

            AccountBalance = AccountBalance - amount;
            TransactionSummery = string.Format("{0}\n Withdraw:{1}", TransactionSummery, amount);
        }

        public override void GenerateAccountReport()
        {
            Console.WriteLine("Current Account report");
            base.GenerateAccountReport();
        }


    }
}
