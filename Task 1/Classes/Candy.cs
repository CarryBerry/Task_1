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
        public Candy()
        {
        }

        public string CandyFilling
        {
            get;
            protected set;
        }
    }
}
