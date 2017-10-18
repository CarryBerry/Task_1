using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    class AmeriCandy : Candy
    {
        public AmeriCandy(string name, string shape, double sugar, double weight, string filling) 
            : base(name, shape, sugar, weight, filling)
        {
            name = "Ameri";
            shape = "star";
            weight = 15;
            sugar = 4;
            filling = "praline";
        }
    }
}
