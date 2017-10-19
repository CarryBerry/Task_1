using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    class MilkaChocolate : Chocolate
    {
        public MilkaChocolate()
        {
            Name = "Milka";
            Shape = "rectangle";
            Weight = 90;
            SugarContent = 23;
            ChocolateType = ChocolateType.Milk;
        }
    }
}
