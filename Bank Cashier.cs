using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace My_Banking_App
{
    class Program
    {

        /// <summary>
        /// This is the main class. 
        /// The Bank is controlled from here
        /// </summary>

        public static void Main(string[] args)
        {
            Console.WriteLine("Alamu Benjamin Oluwaseun\n150805512\nCSC322");
            double CURRENTYEAR = 2017;
            Customer c = new Customer(); //Create an object of the Customer Class
            string input = "";

            //A loop that continually tries to get the type of Account the Customer was to create
            while ((input != "1") && (input != "2") && (input != "3"))
            {
                Console.WriteLine("\nWhich type of Account do you want to open\nKindly pick the corresponding number");
                Console.WriteLine("1 - Savings\n2 - Current\n3 - Student Account");
                input = Console.ReadLine();
                if ((input != "1") && (input != "2") && (input != "3"))
                {
                    Console.WriteLine("Invalid input\nTry Again");
                }
            }


            if (input == "1")
            {
                if ((CURRENTYEAR - c.YearOfBirth) >= 18) //Check the Customer is old enough to create such an Account
                {
                    Account account = new SavingsAccount();
                    performTasks(c, account);
                }
                else
                {
                    //If the Customer is not old enough to create such an account, then an alternative is suggested 
                    Console.WriteLine("You are not old enough to own a savings Account\nYou to create a student Account\nTo Create a Student Account Press 1, Press any other key to cancel");
                    string userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        Account account = new StudentAccount();
                        performTasks(c, account);
                    }
                    else
                    {
                        Console.WriteLine("Application Quit");
                    }
                }

            }

            else if (input == "2")
            {
                if ((CURRENTYEAR - c.YearOfBirth) >= 18) //Check is Customer is old enough to open such an Account
                {
                    Account account = new CurrentAccount();
                    performTasks(c, account);
                }
                else
                {
                    //If the user is not old enoug to open such an account, an alternative is suggested
                    Console.WriteLine("You are not old enough to own a current Account\nYou need to create a student Account\nTo Create a Student Account Press 1, Press any other key to cancel");
                    string userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        Account account = new StudentAccount();
                        performTasks(c, account);
                    }
                    else
                    {
                        Console.WriteLine("Application Quit");
                    }
                }
            }
            else if (input == "3")
            {
                if ((CURRENTYEAR - c.YearOfBirth) < 15) //Check the eligibility of the Customer to open such an account
                {
                    Console.WriteLine("Sorry, you are too young to own a bank account");
                    Console.ReadKey();
                }
                else if ((CURRENTYEAR - c.YearOfBirth) > 19) //Suggesting alternatives for the customer
                {
                    Console.WriteLine("You are too old to open a Students Account\nYou need to open a Current or Savings Account\nFor Savings Account press 1, For Current Account Press 2\nTo Quit Press any other key");
                    string userInput = Console.ReadLine();
                    if (userInput == "1")
                    {
                        Account account = new SavingsAccount();
                        performTasks(c, account);
                    }
                    else if (userInput == "2")
                    {
                        Account account = new CurrentAccount();
                        performTasks(c, account);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input\n Application is quitting");
                    }

                }
                else
                {
                    Account account = new StudentAccount();
                    performTasks(c, account);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        /// <summary>
        /// Performs the tasks.
        /// </summary>
        /// <param name="cus">The Customer Object.</param>
        /// <param name="account">The Account object. It also specifies the type of Account be used</param>
        public static void performTasks(Customer cus, Account account)
        {
            //A method that performs the tasks which the customer wants to perform according to the input provided by the customer
            int am;
            String amount;
            String entry = "";
            account.GenerateAccountNumber();
            while (entry != "8")
            {
                Console.WriteLine("What transaction would you like to perform\nSelect the number corresponding with the transaction");
                Console.WriteLine("1 - Deposit\n2 - Withdrawal\n3 -  Transfer\n4 - Check Balance\n5- View Details\n6 - Update Details\n7 - View Account Number\n8 - Quit");
                Console.WriteLine();
                entry = Console.ReadLine();
                Console.WriteLine();
                if (entry == "1")
                {
                    Console.WriteLine("How much do you want to deposit");
                    amount = Console.ReadLine();
                    am = int.Parse(amount);
                    account.Deposit(am);
                }
                else if (entry == "2")
                {
                    Console.WriteLine("How much do you want to withdraw");
                    amount = Console.ReadLine();
                    am = int.Parse(amount);
                    account.Withdraw(am);
                }
                else if (entry == "3")
                {
                    Console.WriteLine("How much do you want to transfer");
                    amount = Console.ReadLine();
                    am = int.Parse(amount);
                    Console.WriteLine("Which account do you want to transfer to:");
                    String acc = Console.ReadLine();
                    account.TransferMoney(acc, am);
                }
                else if (entry == "4")
                {
                    account.GetAccountBalance();
                }
                else if (entry == "5")
                {
                    cus.getCustomerDetails();
                }
                else if (entry == "6")
                {
                    cus.UpdateCustomerDetails();
                }
                else if (entry == "7")
                {
                    account.GetAccountNumber();
                }
                else if (entry == "8")
                {
                    Console.WriteLine("Application quit");
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            Console.WriteLine();
        }
    }


}
