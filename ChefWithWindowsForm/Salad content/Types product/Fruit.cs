using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefWithWindowsForm
{
    [Serializable]
    public class Fruit : Product, IFormattable
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
            return "Fruit " + base.ToString(format, formatProvider);
        }

        public Fruit():base()
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Apple"] = 37.0,
                ["Banana"] = 89.0,
                ["Mandarin"] = 40.0,
                ["Grapes"] = 45.0,
                ["Orange"] = 38.0,
                ["Grapes"] = 45.0,
                ["Apricots"] = 41.0,
                ["Pineapple"] = 49.0,
                ["Mango"] = 67.0,
                ["Garnet"] = 52.0,
                ["Grapefruit"] = 38.0
            };
        }

        public Fruit(
            string name,
            double weight,
            double proteins,
            double fats,
            double carbohydrates)
            : base(name, weight, proteins, fats, carbohydrates)
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Apple"] = 37.0,
                ["Banana"] = 89.0,
                ["Mandarin"] = 40.0,
                ["Grapes"] = 45.0,
                ["Orange"] = 38.0,
                ["Grapes"] = 45.0,
                ["Apricots"] = 41.0,
                ["Pineapple"] = 49.0,
                ["Mango"] = 67.0,
                ["Garnet"] = 52.0,
                ["Grapefruit"] = 38.0
            };
            Calories();
        }
    }
}
