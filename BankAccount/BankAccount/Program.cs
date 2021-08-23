using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcccount savingaccoun = new SavingBankAccount("Mohammad Tanjeebur Rahman Chowdhury", "235475541");

            BankAcccount Currentaccount = new CurrentBakAccount("Jackson", "125465465421");

            savingaccoun.Deposite(40000);
            savingaccoun.Withdraw(500);
            savingaccoun.Withdraw(2002);
            savingaccoun.Withdraw(6000);
            savingaccoun.GenerateAccountReport();

            Console.WriteLine();

            Currentaccount.Deposite(200000);
            Currentaccount.Withdraw(6000);
            Currentaccount.GenerateAccountReport();

            Console.ReadLine();

        }
    }
}
