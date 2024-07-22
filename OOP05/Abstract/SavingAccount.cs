using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Abstract
{
    //Concrete Class
    internal class SavingAccount : BankAccount
    {

        public SavingAccount(int accountNumber , string? accountHolder) :base (accountNumber , accountHolder)
        {    
        }

        public override void Deposite(double amount)
        {
            //If amount is less than 0 
            Balance = amount <= 0 ? 0 : amount;
        }

        public override void Withdraw(double amount)
        {
            Balance = amount <= 0 ? Balance -0 : amount > Balance ? Balance - 0 : Balance -= amount;
        }
    }
}
