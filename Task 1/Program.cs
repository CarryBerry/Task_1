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
            GiftBuilder giftbuilder = new GiftBuilder(gift1);
            giftbuilder.Build();

            Console.WriteLine("Sweets sorted by name: \n");
            SweetsOutputHelper.SweetsOutput(gift1.SortByName());

            //Console.WriteLine();

            Console.WriteLine("\nSweets sorted by sugar content: \n");
            SweetsOutputHelper.SweetsOutput(gift1.SortBySugarContent());

            //Console.WriteLine();

            double lowerSugarContent = 1.2;
            double upperSugarContent = 10;
            Console.WriteLine("\nSweets with sugar content from {0} to {1}: \n", lowerSugarContent, upperSugarContent);
            SweetsOutputHelper.SweetsOutput(gift1.SearchBySugarContent(lowerSugarContent, upperSugarContent));

            Console.WriteLine("\nTotal weight of the {0} is: {1}", gift1.Name, gift1.TotalWeight);
            
            Console.ReadKey();
        }
    }
}
