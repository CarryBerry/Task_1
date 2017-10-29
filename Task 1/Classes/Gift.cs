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

        public int SweetCount
        {
            get
            {
                return Sweets.Count;
            }
        }
        
        public void SweetAdd(ISweet item)
        {
            Sweets.Add(item);
        }

        public void SweetClear()
        {
            Sweets.Clear();
        }

        public bool SweetContains(ISweet item)
        {
            return Sweets.Contains(item);
        }

        public bool SweetRemove(ISweet item)
        {
            return Sweets.Remove(item);
        }

        public ICollection<ISweet> SortByWeight()
        {
            var sortByWeight = Sweets.OrderBy(x => x.Weight).ToList();
            return sortByWeight;
        }

        public ICollection<ISweet> SortByName()
        {
            var sortByName = Sweets.OrderBy(x => x.Name).ToList();
            return sortByName;
        }

        public ICollection<ISweet> SortBySugarContent()
        {
            var sort = Sweets.OrderBy(x => x.SugarContent).ToList();
            return sort;
        }

        public ICollection<ISweet> SearchBySugarContent(double lower, double upper)
        {
            var sweetsBySugarContent = Sweets
                .Where(x => x is ISweet)
                .Where(x => ((ISweet)x).SugarContent >= lower)
                .Where(x => ((ISweet)x).SugarContent <= upper)
                .ToList();
            return sweetsBySugarContent;


                //= from item in Sweets
                //         orderby item.SugarContent
                //         where item.SugarContent >=lower
                //         where item.SugarContent <=upper
                //         select item;
        }

        public double TotalWeight
        {
            get
            {
                var totalWeight = Sweets.Sum(x => x.Weight);
                return totalWeight;
            }
        }
    }
}
