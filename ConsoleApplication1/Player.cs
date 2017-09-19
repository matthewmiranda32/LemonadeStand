using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Player
    {
        public double cash;
        public double profit;
        public double expenses;
        public double lemonadePrice;

        public Inventory inventory = new Inventory();
        public Wallet wallet = new Wallet();

        public void SetLemonadePrice()
        {
            Console.WriteLine("Set the price for your lemonade: ");
            lemonadePrice = Convert.ToInt32(Console.ReadLine());
        }
        //public double CalculateExpenses(Wallet wallet)
        //{
        //   double expenses = wallet.SubtractMoney();
        //}
        //public double CalculateProfits(Wallet wallet)
        //{
        //    profit = wallet.AddMoney();
        //}
    }
}
