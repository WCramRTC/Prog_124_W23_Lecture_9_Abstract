using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_9_Abstract
{
    class ColdDrink : Drink
    {
        bool _hasIce;

        public ColdDrink(string name, decimal price, string sku, Size drinkSize, bool hasIce) : base(name, price, sku, drinkSize)
        {
            _hasIce = hasIce;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Has Ice {_hasIce}";
        }
    }
}
