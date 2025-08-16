using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asssigment
{
    internal class Discount
    {
        public string Name { get; set; }

        public Discount(string name)
        {
            Name = name;
        }

        public abstract decimal CalculateDiscount(decimal price, int quantity);
        }

}
