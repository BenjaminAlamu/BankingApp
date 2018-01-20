using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace My_Banking_App
{
    /// <summary>
    /// This is the Student Account class and it inherits from the Account Class
    /// </summary>
    class StudentAccount : Account
    {

        /// <summary>
        /// This is the maximum amount that can be in this account
        /// </summary>
        public readonly double MAXBALANCE = 1000000;

        /// <summary>
        /// This is the minimum amount that can be in this account
        /// </summary>
        private readonly double MINBALANCE = 0;

        /// <summary>
        /// This is the maximum amount that can be withdrawn at a time from this account
        /// </summary>
        private readonly double MAXWITHDRAWAL = 500000;

        /// <summary>
        /// This sis the maximum amount that can be deposited into this accouhnt at a time
        /// </summary>
        private readonly double MAXDEPOSIT = 100000;

        /// <summary>
        /// This is the maximum amiunt that can transfered from this account at a time
        /// </summary>
        private readonly double MAXTRANSFER = 500000;

        /// <summary>
        /// The balance if the account
        /// </summary>
        private double balance = 0;

        /// <summary>
        /// The account number
        /// </summary>
        private String accountNumber;

        /// <summary>
        /// Withdraws the specified amount.
        /// </summary>
        /// <param name="amount">The amount to be withdrawn.</param>
        public override void Withdraw(double amount)
        {
            if ((balance < amount) || ((balance - amount) < MINBALANCE)) //Check if balance if enough to withdraw that amount 
            {
                Console.WriteLine("Balance not sufficient");
            }
            else if (amount > MAXWITHDRAWAL) // Check if balance is more than  maximum allowed withdrawal
            {
                Console.WriteLine("The amount {0} you are trying to withdraw is more than maximum amount you are allowed to withdraw");
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
            {
                if (amount > MAXDEPOSIT)
                { //Check if amount to be deposited is not more than the maximum allowed deposit
                    Console.WriteLine("The amount {0} you are trying to deposit is more than maximum amount you are allowed to deposit");
                }
                else if ((balance + amount) > MAXBALANCE)
                {  //Check if deposit will take the balance above the Maximum allowed balance
                    Console.WriteLine("You cannot deposit this amount because it takes your balance above the maximum allowed balance for your account");
                }
                else
                {
                    balance += amount; //Deposit the money and increment the account balance
                    Console.WriteLine("{0} has been deposited into your account {1} is your balance", amount, balance);
                }
            }
        }
        /// <summary>
        /// Transfers the money.
        /// </summary>
        /// <param name="toAccount">The account the money is deposited into.</param>
        /// <param name="amount">The amount to be deposited.</param>
        public override void TransferMoney(string toAccount, double amount)
        {
            {

                if (toAccount.Length == 10) //Check the length of the acoount number to ensure it is a real account
                {
                    if (balance < amount) //Check the available funds in tha account
                    {
                        Console.WriteLine("Insufficient funds");
                    }
                    else if ((balance - amount) < MINBALANCE) //Check if the transfer will make the balance below the Minimum balance
                    {
                        Console.WriteLine("You cannot transfer this amount because it takes your balance below the minimum allowed balance for your account");
                    }
                    else if (amount > MAXTRANSFER) //Check if the the amount being transferred is more the Maximum allowed transfer amount
                    {
                        Console.WriteLine("The amount {0} you are trying to transfer is more than the Maximimum you can transfer which is {1}", amount, MAXTRANSFER);
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
            String accNum = "00101"; //Create an empty string to save the account number
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
