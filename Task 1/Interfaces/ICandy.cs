using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Interfaces
{
    interface ICandy : ISweet
    {
        string CandyFilling { get; }
    }
}
