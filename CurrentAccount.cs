using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Banking_App
{
    /// <summary>
    /// The Current Account class, it inherits from the account class
    /// </summary>
    class CurrentAccount : Account
    {
        /// <summary>
        /// The balance of the account
        /// </summary>
        private double balance;

        /// <summary>
        /// The account number
        /// </summary>
        private String accountNumber;

        /// <summary>
        /// This is the minimum amount that can be in the account
        /// </summary>
        private readonly double MINBALANCE = 1000;


        /// <summary>
        /// Withdraws the specified amount.
        /// </summary>
        /// <param name="amount">The amount to be withdrawn</param>
        public override void Withdraw(double amount)
        {
            if ((balance < amount) || ((balance-amount) < MINBALANCE))  //Check if balance if enough to withdraw that amount 
            {
                Console.WriteLine("Balance not sufficient");
            }
            else //Withdraw the entered amount
            {
                balance -= amount;
                Console.WriteLine("{0} has been withdrawn from your account {1} is your balance", amount, balance);
            }
        }

        /// <summary>
        /// Deposits the specified amount.
        /// </summary>
        /// <param name="amount">The amount to be deposited.</param>
        public override void Deposit(double amount)
        {
            balance += amount; //Deposit the money and increment the account balance
            Console.WriteLine("{0} has been deposited into your account {1} is your balance", amount, balance);
        }

        /// <summary>
        /// Transfers the money from the current customer account to the account supplied by the Customer.
        /// </summary>
        /// <param name="toAccount">To account which the money will be transfered to.</param>
        /// <param name="amount">The amount to be transferred.</param>
        public override void TransferMoney(string toAccount, double amount)
        {
            {

                if (toAccount.Length == 10) //Check the length of the acoount number to ensure it is a real account
                {
                   if ((balance - amount) < MINBALANCE)
                    {
                        Console.WriteLine("Balance not enough");
                    }
                    else
                    {
                        balance -= amount; //Transfer the funds to the account and debit the account
                        Console.WriteLine("{0} has been transferred from your account {1} to {2}, your current balance is {3}", amount, accountNumber, toAccount, balance);
                    }
                }
                else
                {
                    Console.WriteLine("The account number {0} you entered is not valid", toAccount);
                }

            }
        }

        /// <summary>
        /// Gets the account balance.
        /// </summary>
        public override void GetAccountBalance()
        {
            Console.WriteLine("You account balance is {0}", balance);
        }
        /// <summary>
        /// Generates the account number.
        /// </summary>
        public override void GenerateAccountNumber()
        {
            String accNum = "00102"; //Create an empty string to save the account number
            Random rnd = new Random(); //Create a random object
            for (int i = 0; i < 5; i++)
            {
                int value = rnd.Next(1, 10);
                accNum += value.ToString(); //Concatenate the generated numbers into the account number
            }
            Console.WriteLine("Here is your account number: " + accNum);
            accountNumber = accNum; // Return the accout number
        }

        /// <summary>
        /// Gets the account number.
        /// </summary>
        public override void GetAccountNumber()
        {
            Console.WriteLine("Your account number is {0}", accountNumber);
        }
    }
}
