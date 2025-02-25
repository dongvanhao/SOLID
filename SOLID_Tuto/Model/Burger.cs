using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tuto.Model
{
    public class Burger :IFood,ICookable
    {
        public string GetName() => "Burger";
        public double GetPrice() => 5.0;
        public void cook() => Console.WriteLine("Cooking Burger");
    }
}
