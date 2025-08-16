using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssigment
{
    internal class PercentageDiscount:Discount
    {
        private decimal percentage;

        public PercentageDiscount(decimal percentage)
            : base("Percentage Discount")
        {
            this.percentage = percentage;
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (percentage / 100);
        }
    }
}
