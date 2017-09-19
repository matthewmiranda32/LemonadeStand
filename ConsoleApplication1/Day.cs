using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Day
    { 
        List<Customer> customer = new List<Customer>();

        public void GenerateCustomers()
        {
            for (int i = 0; i < 101; i++)
            {
                customer.Add(new Customer());
            }
        }
        public void DayGoesBy()
        {

        }
    }
}
