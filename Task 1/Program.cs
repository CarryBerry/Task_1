using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Classes;
using Task_1.Interfaces;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Gift gift1 = new Gift("Christmass gift", new List<ISweet>());

            var candy1 = new RaffaelloCandy();
            var candy2 = new RaffaelloCandy();
            var candy3 = new AmeriCandy();
            var candy4 = new RaffaelloCandy();
            
            gift1.SweetAdd(candy1);
            gift1.SweetAdd(candy2);
            gift1.SweetAdd(candy3);
            gift1.SweetAdd(candy4);

            gift1.ShowAll();

            gift1.SortByWeight();

            gift1.SearchBySugarContent(1, 4);

            Console.WriteLine(gift1.TotalWeight);
            
            Console.ReadKey();
        }
    }
}
