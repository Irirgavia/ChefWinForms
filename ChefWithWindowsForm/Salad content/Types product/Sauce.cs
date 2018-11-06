using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefWithWindowsForm
{
    [Serializable]
    public class Sauce : Product, IFormattable
    {
        public override double Calories()
        {
            bool isFindType = false;

            foreach (var type in dictionaryTypeProduct.Keys)
            {
                if (type == NameProduct)
                {
                    isFindType = true;
                    break;
                }
            }

            if (isFindType)
            {
                return Weight * dictionaryTypeProduct[NameProduct] / 100;
            }
            else return base.Calories();
        }

        public override string ToString(string format, IFormatProvider formatProvider)
        {
            return "Sauce " + base.ToString(format, formatProvider);
        }

        public Sauce() : base()
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["SourCream"] = 206.0,
                ["Mayonnaise"] = 254.0,
                ["Butter"] = 899.0
            };
        }

        public Sauce(
            string name,
            double weight,
            double proteins,
            double fats,
            double carbohydrates)
            : base(name, weight, proteins, fats, carbohydrates)
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["SourCream"] = 206.0,
                ["Mayonnaise"] = 254.0,
                ["Butter"] = 899.0
            };
            Calories();
        }
    }
}
