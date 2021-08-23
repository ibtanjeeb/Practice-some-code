using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccount
{
   public abstract class BankAcccount
    {
        public string AccountOwnerName { get; set; }
        public string Accountnumber { get; set; }
        
        public decimal AccountBalance { get; protected set; }

        protected Decimal MinaccountBalance { get; set; }
        protected decimal MaxDepositeAmount { get; set; }

        protected decimal InterestRate { get; set; }
        protected string TransactionSummery { get; set; }
        protected BankAcccount(string accountOwerName,string accountnumber)
        {
            AccountOwnerName = accountOwerName;
            Accountnumber = accountnumber;
            TransactionSummery = string.Empty;
        }
        public abstract void Deposite(decimal amount);
        public abstract void Withdraw(decimal amount);

        public decimal CalculateInterest()
        {
            return (this.AccountBalance * this.InterestRate) / 100;

        }

        public virtual void GenerateAccountReport()
        {
            Console.WriteLine("Account Owner:{0},Account Number:{1}",this.AccountOwnerName,this.Accountnumber);
            Console.WriteLine("Account Balance:{0}",this.AccountBalance);
            Console.WriteLine("Interest Amount :{0}",this.CalculateInterest());
            Console.WriteLine("{0}",this.TransactionSummery);

        }


    }
}
