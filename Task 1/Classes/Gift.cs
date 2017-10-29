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

        public IEnumerable<ISweet> SortByWeight()
        {
            var sortByWeight = Sweets.OrderBy(x => x.Weight).ToArray();
            return sortByWeight;
        }

        public IEnumerable<ISweet> SortByShape()
        {
            var sortByShape = Sweets.OrderBy(x => x.Shape).ToArray();
            return sortByShape;
        }

        public IEnumerable<ISweet> SortByName()
        {
            var sortByName = Sweets.OrderBy(x => x.Name).ToArray();
            return sortByName;
        }

        public IEnumerable<ISweet> SortBySugarContent()
        {
            var sortBySugarContent = Sweets.OrderBy(x => x.SugarContent).ToArray();
            return sortBySugarContent;
        }

        public IEnumerable<ISweet> SearchBySugarContent(double lower, double upper)
        {
            var sweetsBySugarContent = Sweets
                .Where(x => x is ISweet)
                .Where(x => x.SugarContent >= lower)
                .Where(x => x.SugarContent <= upper)
                .ToArray();
            return sweetsBySugarContent;
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
