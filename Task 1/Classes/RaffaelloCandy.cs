using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    public class RaffaelloCandy : Candy
    {
        public RaffaelloCandy(string name, string shape, double sugar, double weight, string filling) 
            : base(name, shape, sugar, weight, filling)
        {
            name = "Raffaello";
            shape = "ball";
            weight = 20;
            sugar = 5;
            filling = "milk cream";
        }
    }
}
