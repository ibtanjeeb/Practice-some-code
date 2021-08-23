using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
    public class SavingBankAccount : BankAcccount
    {
        protected int withdrawCount = 0;

        public SavingBankAccount(string accountownerName, string accountNumber)
        : base(accountownerName, accountNumber)
        {
            this.MinaccountBalance = 20000m;
            this.MaxDepositeAmount = 50000m;

            this.InterestRate = 3.5m;


        }


        public override void Deposite(decimal amount)
        { 
            if (amount>=MaxDepositeAmount)
        {

            throw new Exception(string.Format("You can not Depoiste greater than: {0}",MaxDepositeAmount.ToString()));
        }
            AccountBalance = AccountBalance + amount;
            TransactionSummery = string.Format("{0}\n Deposite:{1}", TransactionSummery, amount);


    }

        public override void Withdraw(decimal amount)
        {
            if(withdrawCount>3)
            {

                throw new Exception("You can not withdraw more than thrice");
            }
            if(AccountBalance -amount <= MinaccountBalance)
            {
                throw new Exception("You can not withdraw amount from your Savings Account as Minimum Balance limit is reached");
            }
            AccountBalance = AccountBalance - amount;
            withdrawCount++;
            TransactionSummery = string.Format("{0}\n Withdraw:{1}", TransactionSummery, amount);
        }
        public override void GenerateAccountReport()
        {
            Console.WriteLine("Saving Account Report");
        
            
            base.GenerateAccountReport();
            if(AccountBalance >15000)
                Console.WriteLine("Sending Email for Account\n",Accountnumber);

        }



    }
}
