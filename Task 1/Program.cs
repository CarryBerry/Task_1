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
            GiftBuilder gb = new GiftBuilder(gift1);
            gb.Build();

            Console.WriteLine("Sweets sorted by name: \n");
            SweetsOutputHelper.SweetsOutput(gift1.SortByName());

            Console.WriteLine();

            Console.WriteLine("Sweets sorted by sugar content: \n");
            SweetsOutputHelper.SweetsOutput(gift1.SortBySugarContent());

            Console.WriteLine();

            double lowerSugarContent = 1.2;
            double upperSugarContent = 4;
            Console.WriteLine("Sweets with sugar content from {0} to {1}: \n", lowerSugarContent, upperSugarContent);
            SweetsOutputHelper.SweetsOutput(gift1.SearchBySugarContent(lowerSugarContent, upperSugarContent));

            Console.WriteLine();

            Console.WriteLine("Total weight of the {0} is: {1}", gift1.Name, gift1.TotalWeight);
            
            Console.ReadKey();
        }
    }
}
