using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefWithWindowsForm
{
    [Serializable]
    public class Vegetable : Product, IFormattable
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
            return "Vegetable " + base.ToString(format, formatProvider);
        }

        public Vegetable() : base()
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Cabbage"] = 27.0,
                ["Carrot"] = 37.0,
                ["Cucumber"] = 15.0,
                ["Onion"] = 41.0,
                ["Zucchini"] = 23.0,
                ["Potatoes"] = 80.0,
                ["Perthushka"] = 49.0,
                ["Tomatoes"] = 23.0,
            };
        }

        public Vegetable(
            string name,
            double weight,
            double proteins,
            double fats,
            double carbohydrates)
            : base(name, weight, proteins, fats, carbohydrates)
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Cabbage"] = 27.0,
                ["Carrot"] = 37.0,
                ["Cucumber"] = 15.0,
                ["Onion"] = 41.0,
                ["Zucchini"] = 23.0,
                ["Potatoes"] = 80.0,
                ["Perthushka"] = 49.0,
                ["Tomatoes"] = 23.0,
            };
            Calories();
        }
    }
}
