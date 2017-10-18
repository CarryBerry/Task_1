using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    public abstract class Sweet : ISweet
    {
        public string Name
        {
            get;
            protected set;
        }

        public string Shape
        {
            get;
            protected set;
        }

        public double SugarContent
        {
            get;
            protected set;
        }

        public double Weight
        {
            get;
            protected set;
        }
    }
}
