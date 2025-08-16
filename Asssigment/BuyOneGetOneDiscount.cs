using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssigment
{
    internal class BuyOneGetOneDiscount:Discount
    {
        public BuyOneGetOneDiscount()
       : base("Buy One Get One Discount") { }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            int eligiblePairs = quantity / 2;
            return (price / 2) * eligiblePairs;
        }
    }
}
