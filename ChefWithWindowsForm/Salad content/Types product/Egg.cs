using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefWithWindowsForm
{
    [Serializable]
    public class Egg : Product, IFormattable
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
            return "Egg " + base.ToString(format, formatProvider);
        }

        public Egg() : base()
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Turkey"] = 165.0,
                ["Goose"] = 185.0,
                ["Agro"] = 380.0,
                ["Chicken"] = 157.0,
                ["Quail"] = 168.0
            };
        }

        public Egg(
            string name,
            double weight,
            double proteins,
            double fats,
            double carbohydrates)
            : base(name, weight, proteins, fats, carbohydrates)
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Turkey"] = 165.0,
                ["Goose"] = 185.0,
                ["Agro"] = 380.0,
                ["Chicken"] = 157.0,
                ["Quail"] = 168.0
            };
            Calories();
        }
    }
}
