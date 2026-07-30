using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class BankAccountClass
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
            set
            {
                if (value < 0) { Console.WriteLine("error, balance can't be negative!"); }
                else
                {
                    balance = value;
                }    

            }
        }

        public double Deposit(double amount) 
        {
            if (amount > 0)
                return Balance + amount;
            else return 0;
        }

        public double Withdraw(double amount) 
        {
            if (Balance > amount)
                return (Balance - amount);
            else return 0;
            
        }
    }
  
}
