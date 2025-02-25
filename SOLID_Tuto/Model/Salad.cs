using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Tuto.Model
{
    public class Salad :IFood
    {
        public string GetName() => "Salad";
        public double GetPrice() => 5.0;
    }
}
