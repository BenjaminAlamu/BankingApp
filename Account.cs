using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace My_Banking_App
{
    /// <summary>
    /// Defines an abstract account class
    /// </summary>
    abstract class Account 
    {

        /// <summary>
        /// Withdraws the specified amount.
        /// </summary>
        /// <param name="amount">The amount to be withdrawn.</param>
        public abstract void Withdraw(double amount); //Abstract withdraw method that is implemented by all derived classes

        /// <summary>
        /// Deposits the specified amount.
        /// </summary>
        /// <param name="amount">The amount to be deposited.</param>
        public abstract void Deposit(double amount); //Abstract deposit method that is implemented by all derived classes

        /// <summary>
        /// Transfers the money.
        /// </summary>
        /// <param name="toAccount">The account the money is to be deposited into</param>
        /// <param name="amount">The amount to be deposited.</param>
        public abstract void TransferMoney(String toAccount, double amount); //Abstract transfer method that is implemented by all derived classes

        /// <summary>
        /// Gets the account balance.
        /// </summary>
        public abstract void GetAccountBalance(); //Abstract GetAccountBalance method that is implemented by all derived classes

        /// <summary>
        /// Generates the account number.
        /// </summary>
        public abstract void GenerateAccountNumber(); //Abstract GeneratedAccountNumber method that is implemented by all derived classes

        /// <summary>
        /// Gets the account number.
        /// </summary>
        public abstract void GetAccountNumber(); ////Abstract GetAccountNumber method that is implemented by all derived classes


    }


}
