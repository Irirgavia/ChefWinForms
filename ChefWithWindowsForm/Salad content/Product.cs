using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChefWithWindowsForm
{
    [Serializable]
    public abstract class Product : IComparable<Product>, IFormattable
    {
        public int CompareTo(Product other)
        {
            if (this.Calories() > other.Calories())
            {
                return 1;
            }
            else if (this.Calories() < other.Calories())
            {
                return -1;
            }
            return 0;
        }

        public Dictionary<string, double> dictionaryTypeProduct;

        public string TypeProduct { get; set; }

        public string NameProduct { get; set; }

        public double Proteins { get; set; }        //белки
        public double Fats { get; set; }            //жиры
        public double Carbohydrates { get; set; }   //углеводы
        
        public double Weight { get; set; }

        public virtual double Calories()
        {
            return (Weight * (9 * Fats + 4 * (Proteins + Carbohydrates))) / 100;
        }

        public virtual string ToString(string format, IFormatProvider formatProvider)
        {
            return NameProduct + " " + Weight.ToString() + " " + Proteins.ToString() + " " + Fats.ToString() + " " + Carbohydrates.ToString();
        }

        public Product()
        {

        }
        public Product(
            string name,
            double weight,
            double proteins,
            double fats,
            double carbohydrates)
        {
            this.NameProduct = name;
            this.Proteins = proteins;
            this.Fats = fats;
            this.Carbohydrates = carbohydrates;
            this.Weight = weight;
        }
    }
}
