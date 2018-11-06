using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefWithWindowsForm
{
    [Serializable]
    public class Seafood : Product, IFormattable
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
            return "Seafood " + base.ToString(format, formatProvider);
        }

        public Seafood():base()
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Fish"] = 137.0,
                ["Caviar"] = 123.0,
                ["Squids"] = 98.0,
                ["Crab"] = 73.0,
                ["CrabSticks"] = 140.0,
                ["Shellfish"] = 77.0,
                ["Cancers"] = 89.0
            };
        }

        public Seafood(
            string name,
            double weight,
            double proteins,
            double fats,
            double carbohydrates)
            : base(name, weight, proteins, fats, carbohydrates)
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Fish"] = 137.0,
                ["Caviar"] = 123.0,
                ["Squids"] = 98.0,
                ["Crab"] = 73.0,
                ["CrabSticks"] = 140.0,
                ["Shellfish"] = 77.0,
                ["Cancers"] = 89.0
            };
            Calories();
        }
    }
}
