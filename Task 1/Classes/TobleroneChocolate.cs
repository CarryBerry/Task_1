using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    class TobleroneChocolate : Chocolate
    {
        public TobleroneChocolate()
        {
            Name = "Toblerone";
            Shape = "triangle";
            Weight = 100;
            SugarContent = 15;
            ChocolateType = ChocolateType.Dark;
        }
    }
}
