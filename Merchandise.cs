using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_W23_Lecture_9_Abstract
{
    public class Merchandise : Product
    {
        public enum Color { Red, Blue, RedBlue, BlueBlue, GreenBlue}

        static int count = 0;

        Color _mugColor;

        public Merchandise(string name, decimal price, string sku , Color mugColor) : base(name, price, sku)
        {
            _mugColor = mugColor;
            count++;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Mug Color: {_mugColor}";
        }

        public override bool InStock()
        {
            if(count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
