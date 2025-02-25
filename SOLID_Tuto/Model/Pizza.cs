using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tuto.Model
{
    public class Pizza : IFood, ICookable
    {
        public String GetName() => "Pizza";
        public double GetPrice() => 10.0;
        public void cook() => Console.WriteLine("Cooking Pizza");
    }
}
