using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Classes;

namespace Task_1.Interfaces
{
    interface ISweet
    {
        double Weight { get; }
        double SugarContent { get; }

        Shape Shape { get; }
    }
}
