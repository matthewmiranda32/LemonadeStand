using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Customer
    {
        public string response;
        public string reply;

        public int buyingChance1 = 100;

        public int buyingChance2 = 80;

        public int buyingChance3 = 60;

        public int buyingchance4 = 40;

        public int buyingChance5 = 20;

        public string LikeTheTaste(Recipie recipie)
        {
            string response = "";
            if (recipie.numberLemons > 6 && recipie.sugarAmount < 2)
            {
                Console.WriteLine("This lemonade is too sour!");
                response = Console.ReadLine();
                int chanceOfPurchase = buyingchance4;
            }

            else if (recipie.numberLemons < 4 && recipie.sugarAmount > 4)
            {
                Console.WriteLine("This lemonade is too sweet!");
                response = Console.ReadLine();
                int chanceOfPurchase = buyingchance4;
            }

            else if (recipie.amountIce < 2)
            {
                Console.WriteLine("Could use more ice.");
                response = Console.ReadLine();
                int chanceOfPurchase = buyingChance3;
            }

            else if (recipie.numberLemons > 6 && recipie.sugarAmount > 4)
            {
                Console.WriteLine("There's too much of everything.");
                response = Console.ReadLine();
                int chanceOfPurchase = buyingChance5;
            }
            else if (recipie.numberLemons < 3 && recipie.sugarAmount < 1)
            {
                Console.WriteLine("That's some light lemonade...Blech!!");
                response = Console.ReadLine();
                int chanceOfPurchase = buyingChance5;
            }
            else
            {
                Console.WriteLine("That's some tasty lemonade!");
                response = Console.ReadLine();
                int chanceOfPurchase = buyingChance1;
            }
            return response;

        }
        public string PayBasedOnPrice(Player player)
        {
            string reply = "";
            if (player.lemonadePrice > 0.45)
            {
                Console.WriteLine("I won't pay that much for lemonade. That's highway robbery!");
                reply = Console.ReadLine();
                int chanceOfPurchase = buyingChance3;
            }
            return reply;
        }

        public string PayAccordingtoWeather(Weather weather)
        {
            string comeback = "";
            if(weather.temperature <= 50)
            {
                Console.WriteLine("It's rather cold. Why are you selling lemonade?");
                comeback = Console.ReadLine();
                int ChanceOfPurchase = buyingchance4;
            }

            else if (weather.temperature > 50 && weather.temperature <= 75)
            {
                Console.WriteLine("Nice day out, isn't it?");
                comeback = Console.ReadLine();
                int ChanceOfPurchase = buyingChance2;
            }

            else if (weather.temperature > 75)
            {
                Console.WriteLine("Hey, lemonade sounds good on a hot day.");
                comeback = Console.ReadLine();
                int ChanceofPurchase = buyingChance1;
            }

            if(weather.weatherType == "Humid")
            {
                Console.WriteLine("Whew! Darn humidity!");
                comeback = Console.ReadLine();
                int ChanceOfPurchase = buyingChance2;
            }

            else if(weather.weatherType == "Rainy")
            {
                Console.WriteLine("Rain, Rain, Go Away.");
                comeback = Console.ReadLine();
                int ChanceOfPurchase = buyingchance4;
            }

            else if(weather.weatherType == "Windy")
            {
                Console.WriteLine("Windy out today, huh?");
                comeback = Console.ReadLine();
                int ChanceOfPurchase = buyingChance3;
            }

            else if(weather.weatherType == "Sunny")
            {
                Console.WriteLine("Ah, bright and sunny! The perfect weather for lemonade!");
                comeback = Console.ReadLine();
                int ChanceOfPurchase = buyingChance1;
            }
            else if(weather.weatherType == "Stormy")
            {
                Console.WriteLine("You gotta be crazy selling lemonade in weather like this.");
                comeback = Console.ReadLine();
                int ChanceOfPurchase = buyingChance5;
            }
            return comeback;
        }
        public void purchaselemonade(Wallet wallet, double cash)
        {


        }

    }
}
