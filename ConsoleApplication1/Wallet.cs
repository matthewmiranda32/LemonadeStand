using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Wallet
    {
        private double balance;
        public Wallet(double startingAmount = 30.00)
        {
            balance = startingAmount;
        }
        public double SubtractMoney(double amount)
        {
            if (balance - amount >= 0) 
            {
                balance -= amount;
            }
             return balance;
        }
        public double AddMoney(double amount)
        {
            balance += amount;
            return balance;
        }
        public double GetBalance() {
            return balance;
        }
    }   
}
