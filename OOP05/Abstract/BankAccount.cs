using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP05.Abstract
{
    public abstract class BankAccount
    {
        public int AccountNum { get;  }

        public string? HolderName { get;  }

        protected double Balance { get; set; }


        //Create a constructor
        protected BankAccount(int accountNumber, string? accountHolder)
        {
            AccountNum = accountNumber;

            HolderName = accountHolder;
        }

        public abstract void Deposite(double amount);
        public abstract void Withdraw(double amount);


        public override string ToString()
        {
            return $"AccountNumber: {AccountNum} - HolderName: {HolderName} - Balance: {Balance}";
        }

        public void Welcome() 
        {
            Console.WriteLine("Welcome to the bank");
        }
    }




   
}
