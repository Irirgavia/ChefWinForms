using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefWithWindowsForm
{
    [Serializable]
    public class Cereal : Product, IFormattable
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
            return "Cereal " + base.ToString(format, formatProvider);
        }

        public Cereal():base()
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Buckwheat"] = 132.0,
                ["Corn"] = 337.0,
                ["Semolina"] = 328.0,
                ["Oatmeal"] = 342.0,
                ["Pearl"] = 320.0,
                ["Millet"] = 348.0,
                ["Rice"] = 344.0
            };
        }

        public Cereal(
            string name,
            double weight,
            double proteins,
            double fats,
            double carbohydrates)
            : base(name, weight, proteins, fats, carbohydrates)
        {
            dictionaryTypeProduct = new Dictionary<string, double>
            {
                ["Buckwheat"] = 132.0,
                ["Corn"] = 337.0,
                ["Semolina"] = 328.0,
                ["Oatmeal"] = 342.0,
                ["Pearl"] = 320.0,
                ["Millet"] = 348.0,
                ["Rice"] = 344.0
            };

            Calories();
        }
    }
}
