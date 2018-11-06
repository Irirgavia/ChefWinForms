using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefWithWindowsForm
{
    [Serializable]
    public class UnknownProduct : Product, IFormattable
    {
        public override double Calories()
        {
            return base.Calories();
        }
        public override string ToString(string format, IFormatProvider formatProvider)
        {
            return "UnknownProduct " + base.ToString(format, formatProvider);
        }

        public UnknownProduct() : base()
        {

        }

        public UnknownProduct(
            string name,
            double weight,
            double proteins,
            double fats,
            double carbohydrates)
            : base(name, weight, proteins, fats, carbohydrates)
        {
            Calories();
        }
    }
}
