using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    class TobleroneChocolate : Chocolate
    {
        public TobleroneChocolate(string name, string shape, double sugar, double weight, ChocolateType chocolateType) 
            : base(name, shape, sugar, weight, chocolateType)
        {
            name = "Toblerone";
            shape = "triangle";
            weight = 100;
            sugar = 15;
            chocolateType = ChocolateType.Dark;
        }
    }
}
