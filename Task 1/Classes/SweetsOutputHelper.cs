using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    public static class SweetsOutputHelper
    {
        public static void SweetsOutput (ICollection<ISweet> sweets)
        {
            foreach (var sweet in sweets)
            {
                Console.WriteLine(sweet.ToString());
            }
        }
    }
}
