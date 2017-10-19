using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Interfaces
{
    public interface IGift
    {
        ICollection<ISweet> Sweets { get; }
        double TotalWeight { get; }
    }
}
