using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Store
    {
        Player player;
        public int choice;
       
        List<string> crateLemons = new List<string> { "1) Small 10-Lemon Crate: $2.50", "2) Medium 30-Lemon Crate: $5.00", "3) Large 60-Lemon Crate: $7.50" };
        List<string> bagsSugar = new List<string> { "1) 1-lb. sugar bag (3 cups): $2.00", "2) 4-lb. sugar bag (12 cups): $4.00", "3) 10-lb. sugar bag (30 cups): $6.00" };
        List<string> iceBags = new List<string> { "1) Small ice bag (100 cubes): $1.50", "2) Medium ice bag (250 cubes): $2.50", "3) Large ice bag (500 cubes): $3.50" };
        List<string> numberCups = new List<string> { "1) Small bag (50 cups): $1.75", "2) Medium bag (100 cups): $2.50", "3) Large bag (250 cups): $4.25" };

        List<double> priceLemons = new List<double> { 2.50, 5.00, 7.50 };
        List<double> priceSugar = new List<double> { 2.00, 4.00, 6.00 };
        List<double> icePriceBaby = new List<double> { 1.50, 2.50, 3.50 };
        List<double> priceofCups = new List<double> { 1.75, 2.50, 4.25 };

        public Store(Player player)
        {
            this.player = player;
        }
        public void SellLemons()
        {
                foreach(string crate in crateLemons)
                {
                       Console.WriteLine(crate);
                }
                Console.WriteLine("How many lemons would you like to purchase? Please type in your choice number.");
                string userInput = Console.ReadLine();
                choice = Convert.ToInt32(userInput);
                if(choice == 1)
                {
                BuyingLemons(10);
                }
                else if(choice == 2)
                {
                BuyingLemons(30);
                }
                else if(choice == 3)
                {
                BuyingLemons(60);
                }
       
        }
        public void SellSugar()   
        {
            
            foreach (string sugarbag in bagsSugar)
            {
                Console.WriteLine(sugarbag);
            }
            Console.WriteLine("How much sugar would you like? Please type in your choice number.");
            string userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            if (choice == 1)
            {
                BuyingSugar(3);
            }
            else if (choice == 2)
            {
                BuyingSugar(12);
            }
            else if (choice == 3)
            {
                BuyingSugar(30);
            }
        } 

        public void SellIce()
        {
            foreach (string ibag in iceBags)
            {
                Console.WriteLine(ibag);
            }
            Console.WriteLine("How much ice would you like? Please type in your choice number.");
            string userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            if (choice == 1)
            {
                PurchaseIce(100);
            }
            else if (choice == 2)
            {
                PurchaseIce(250);
            }
            else if (choice == 3)
            {
                PurchaseIce(500);
            }
        }

        public void SellCups()
        {          
            foreach (string cupamount in numberCups)
            {
                Console.WriteLine(cupamount);
            }
            Console.WriteLine("How many cups would you like to purchase? Please type in your choice number.");
            string userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            if (choice == 1)
            {
                PurchaseCups(50);
            }
            else if (choice == 2)
            {
                PurchaseCups(100);
            }
            else if (choice == 3)
            {
                PurchaseCups(250);
            }
        }
       
       public void BuyingLemons(double lemonsPurchased)
       {
            for (double i = 1; i <= lemonsPurchased; i++)
            {
                Lemon lemon = new Lemon();
                player.inventory.Lemons.Add(lemon);
                if (lemonsPurchased == priceLemons.IndexOf(0))
                {
                    player.wallet.SubtractMoney(2.5);
                    player.inventory.AddLemons(10);
                }

                else if(lemonsPurchased == priceLemons.IndexOf(1))
                {
                    player.wallet.SubtractMoney(5.0);
                    player.inventory.AddLemons(30);
                }

                else if(lemonsPurchased == priceLemons.IndexOf(2))
                {
                    player.wallet.SubtractMoney(7.5);
                    player.inventory.AddLemons(60);
                }
            }
       
         }

       public void BuyingSugar(double sugarPurchased)
       {
        for (double i = 1; i <= sugarPurchased; i++)
        {
            Sugar sugar = new Sugar();
            player.inventory.Sugar.Add(sugar);
            if (sugarPurchased == priceSugar.IndexOf(0))
            {
                player.wallet.SubtractMoney(2.0);
                player.inventory.AddSugar(3);
            }

            else if (sugarPurchased == priceSugar.IndexOf(1))
            {
                player.wallet.SubtractMoney(4.0);
                player.inventory.AddSugar(12);
            }

            else if (sugarPurchased == priceSugar.IndexOf(2))
            {
                player.wallet.SubtractMoney(6.0);
                player.inventory.AddSugar(30);
            }
        }

    }
        public void PurchaseIce(double icePurchased)
        {
            for (double i = 1; i <= icePurchased; i++)
            {
                Ice ice = new Ice();
                player.inventory.Ice.Add(ice);
                if (icePurchased == icePriceBaby.IndexOf(0))
                {
                    player.wallet.SubtractMoney(1.5);
                    player.inventory.AddIce(100);
                }

                else if (icePurchased == icePriceBaby.IndexOf(1))
                {
                    player.wallet.SubtractMoney(2.5);
                    player.inventory.AddIce(250);
                }

                else if (icePurchased == icePriceBaby.IndexOf(2))
                {
                    player.wallet.SubtractMoney(3.5);
                    player.inventory.AddIce(500);
                }
            }
        }

        public void PurchaseCups(double cupsPurchased)
        {
            for (double i = 1; i <= cupsPurchased; i++)
            {
                Cup cup = new Cup();
                player.inventory.Cups.Add(cup);
                if (cupsPurchased == priceofCups.IndexOf(0))
                {
                    player.wallet.SubtractMoney(1.75);
                    player.inventory.AddCups(50);
                }

                else if (cupsPurchased == priceofCups.IndexOf(1))
                {
                    player.wallet.SubtractMoney(2.5);
                    player.inventory.AddCups(100);
                }

                else if (cupsPurchased == priceofCups.IndexOf(2))
                {
                    player.wallet.SubtractMoney(4.25);
                    player.inventory.AddCups(250);
                }
            }
        }
    }
}
