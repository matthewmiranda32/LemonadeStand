using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Recipie
    {
        public int numberLemons;
        public int sugarAmount;
        public int amountIce;
        public int pitcherNumber;

        public void AddLemons(Inventory inventory)
        {
            Console.WriteLine("How many lemons would you like to use?");
            numberLemons = Convert.ToInt32(Console.ReadLine());
            inventory.SubtractLemons(numberLemons);
        }

        public void AddSugar(Inventory inventory)
        {
            Console.WriteLine("How many cups of sugar would you like to use?");
            sugarAmount = Convert.ToInt32(Console.ReadLine());
            inventory.SubtractSugar(sugarAmount);
        }

        public void AddIce(Inventory inventory)
        {
            Console.WriteLine("How many ice cubes would you like to add?");
            amountIce = Convert.ToInt32(Console.ReadLine());
            inventory.SubtractIce(amountIce);
        }

        public void MakePitcher()
        {
            Console.WriteLine("How many pitchers would you like to make?");
            pitcherNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
