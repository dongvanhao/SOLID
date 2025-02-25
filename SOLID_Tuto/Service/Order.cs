using SOLID_Tuto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tuto.Service
{
    public class Order
    {
        public List<IFood> Items { get; private set; } = new List<IFood>();

        public void AddItem(IFood food)
        {
            Items.Add(food);
            Console.WriteLine($"THem{food.GetName()} vao don hang");
        }
        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.GetPrice();
            }
            return total;
        }
    }
}
