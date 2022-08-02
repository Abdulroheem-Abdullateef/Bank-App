using System;
using System.Collections.Generic;

namespace Question_4_OOP_class
{
    class Program
    {
        static void Main(string[] args)
        {
            
            BankAccount account = new BankAccount("312793751","Abdullateef", DateTime.Now);
            BankAccount account1 = new BankAccount("312793751", "Owolabi", DateTime.Now);

            bool check = true;

            while (check)
            {
                Console.WriteLine("Enter a number between 1 to 5 to perform this operation ");
                Console.WriteLine("Enter  1 to deposit\nEnter 2 to withdraw\nEnter 3 to check balance account\nEnter 4 to transaction History\n Enter 5 to Stop :");
                int respond = int.Parse(Console.ReadLine());

                if (respond == 1)
                {
                    Console.WriteLine($"Enter amount to deposit ");
                    double deposit = double.Parse(Console.ReadLine());
                    account.Deposit(deposit);
                    
                }

                else if(respond == 2)
                {
                    Console.WriteLine($"Enter amount to Withdraw ");
                    double withdraw = double.Parse(Console.ReadLine());
                    account.WithDraw(withdraw);
                    
                }

                else if (respond == 3)
                {
                    account.CheckAccountBalance();
                    
                }

                else if(respond==4)
                {
                    account.TransactionHistory();
                 
                }

                else if (respond==5)
                {
                    check = false;
                }

            }
        }    
    }

}