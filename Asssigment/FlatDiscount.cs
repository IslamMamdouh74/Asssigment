using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssigment
{
    internal class FlatDiscount:Discount
    {
        private decimal flatAmount;

        public FlatDiscount(decimal flatAmount)
            : base("Flat Discount")
        {
            this.flatAmount = flatAmount;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return flatAmount * Math.Min(quantity, 1);
        }
    }
}
