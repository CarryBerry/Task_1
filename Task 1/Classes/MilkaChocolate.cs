using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    class MilkaChocolate : Chocolate
    {
        public MilkaChocolate(string name, string shape, double sugar, double weight, ChocolateType chocolateType) 
            : base(name, shape, sugar, weight, chocolateType)
        {
            name = "Milka";
            shape = "rectangle";
            weight = 90;
            sugar = 23;
            chocolateType = ChocolateType.Milk;
        }
    }
}
