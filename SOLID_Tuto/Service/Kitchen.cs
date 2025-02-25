using SOLID_Tuto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tuto.Service
{
    public class Kitchen
    {
        public void PrepareFood(ICookable food)
        {
            food.cook();
            Console.WriteLine($"{food.GetType().Name} da duoc chuan bi xong");
        }
    }
}
