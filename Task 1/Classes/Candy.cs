using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    public class Candy : Sweet, ICandy
    {
        public Candy (string name, string shape, double sugar, double weight, string filling)
        {
            Name = name;
            Shape = shape;
            SugarContent = sugar;
            Weight = weight;
            CandyFilling = filling;
        }

        public string CandyFilling
        {
            get;
            protected set;
        }
    }
}
