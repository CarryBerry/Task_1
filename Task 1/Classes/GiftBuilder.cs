using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1.Classes
{
    public class GiftBuilder
    {
        private Gift _sweet;

        public GiftBuilder(Gift sweet)
        {
            _sweet = sweet;
        }

        public void AddSweets()
        {
            _sweet.SweetAdd(new RaffaelloCandy());
            _sweet.SweetAdd(new AmeriCandy());
            _sweet.SweetAdd(new RaffaelloCandy());
            _sweet.SweetAdd(new RaffaelloCandy());
            _sweet.SweetAdd(new TobleroneChocolate());
        }

        public void Build()
        {
            AddSweets();
        }
    }
}
