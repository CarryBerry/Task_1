using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.Interfaces;

namespace Task_1.Classes
{
    public class Gift : IGift, INameable
    {
        public string Name
        {
            get;
            private set;
        }

        public ICollection<ISweet> Sweets
        {
            get;
            private set;
        }

        public Gift (string name, ICollection<ISweet> sweets)
        {
            Name = name;
            Sweets = sweets;
        }

        public int Count
        {
            get
            {
                return Sweets.Count;
            }
        }

        double IGift.TotalWeight
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(ISweet item)
        {
            Sweets.Add(item);
        }

        public void Clear()
        {
            Sweets.Clear();
        }

        public bool Contains(ISweet item)
        {
            return Sweets.Contains(item);
        }

        public bool Remove(ISweet item)
        {
            return Sweets.Remove(item);
        }

        public void SortByWeight()
        {
            var search = from item in Sweets
                         orderby item.Weight
                         select item;
            foreach (var i in search)
            {
                Console.WriteLine((i.Name+"\t"+i.Weight).ToString());
            }
        }

        public void SortByName()
        {
            var search = from item in Sweets
                         orderby item.Name
                         select item;
            foreach (var i in search)
            {
                i.Name.ToString();
            }
        }

        public void SortBySugarContent()
        {
            var search = from item in Sweets
                         orderby item.SugarContent
                         select item;
            foreach (var i in search)
            {
                (i.Name + "\t" + i.SugarContent).ToString();
            }
        }

        public void ShowAll()
        {
            foreach (var i in Sweets)
            {
                Console.WriteLine(i.ToString());
            }
        }

        public void SearchBySugarContent(double lower, double upper)
        {
            var search = from item in Sweets
                         orderby item.SugarContent
                         where item.SugarContent >=lower
                         where item.SugarContent <=upper
                         select item;
            foreach (var i in search)
            {
                Console.WriteLine((i.Name + "\t" + i.SugarContent).ToString());
            }
        }

        public double TotalWeight()
        {
            double totalWeight = 0;
            var search = from item in Sweets
                         select item;
            foreach (var i in search)
            {
                totalWeight += i.Weight;
            }
            return totalWeight;
        }
    }
}
