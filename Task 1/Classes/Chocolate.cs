using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    class Chocolate : Sweet, IChocolate
    {
        public Chocolate()
        {
        }

        public ChocolateType ChocolateType
        {
            get;
            protected set;
        }
    }
}
