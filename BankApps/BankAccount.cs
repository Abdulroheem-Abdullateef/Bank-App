using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4_OOP_class
{
    class BankAccount
    {
        private string AccountNumber;
        private string AccountName;
        private DateTime DateCreated;
        public double AccountBalance;

      

        List<string> History = new List<string>();

        public BankAccount(string accountnumber, string accountname, DateTime dateCreated)
        {
            AccountNumber = accountnumber;
            AccountName = accountname;
            Deposit(10000);
            DateCreated = dateCreated;
        }

        public void Deposit(double deposit )
        {
            
            AccountBalance = AccountBalance + deposit;
            string a = $"you deposit {deposit} and balance is {AccountBalance}";
            History.Add(a);
            Console.WriteLine(a);
        }

        public void WithDraw(double withdraw)
        {
           
            if (withdraw <= AccountBalance)
            {
                AccountBalance = AccountBalance - withdraw;
                string balance = $"your balance is {AccountBalance}"; 
                History.Add(balance);
                
                Console.WriteLine($"{AccountName} you withdraw {balance} at {DateTime.Now} ");
            }

            else
            {
                Console.WriteLine("Insulfficient balance");
            }

        }

        public void CheckAccountBalance()
        {
            Console.WriteLine($"Your account balance is {AccountBalance} ");
        }

        public void TransactionHistory()
        {
            foreach (var item in History)
            {
                Console.WriteLine(item);
            }
        }
    }
}
