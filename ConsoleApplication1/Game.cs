using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Game
    {
    public void RulesDisplay()
    {
            Console.WriteLine("Welcome to the Lemonade Stand Training Program. Here, you will learn how to make and sell lemonade, along with making some serious bank.");
            Console.ReadLine();
            Console.WriteLine("You need to buy your supplies first. You have 30 dollars right now. Spend it wisely.");
            Console.ReadLine();
    }

    public void PlayTheGame()
    {
            Player player = new Player();
            Store store = new Store(player);
            store.SellLemons();
            store.SellSugar();
            store.SellIce();
            store.SellCups();
            int lemonCount = player.inventory.Lemons.Count;
            int sugarAmount = player.inventory.Sugar.Count;
            int iceCount = player.inventory.Ice.Count;
            int cupAmount = player.inventory.Cups.Count;
            Console.WriteLine(player.wallet.GetBalance());
            Console.WriteLine("Now, it's time to make some lemonade! Create your recipie as you see fit. You have " +lemonCount+ " lemons, " +sugarAmount+ " cups of sugar, " +iceCount+ " ice cubes and " +cupAmount+ " cups. ");
            Recipie recipie = new Recipie();
            recipie.AddLemons(player.inventory);
            recipie.AddSugar(player.inventory);
            recipie.AddIce(player.inventory);
            Weather weather = new Weather();
            Console.WriteLine("The weather tomorrow will be " +weather.temperature+ " and " +weather.weatherType+ ".");
            player.SetLemonadePrice();
            Day day = new Day();
            day.GenerateCustomers();
            Customer customer = new Customer();
            
    }
    }
}
