using System;
using System.Collections.Generic;

namespace ChefWithWindowsForm
{
    [Serializable]
    public class Salad
    {
        public string Name { get; set; }
        
        public List<Product> ProductSalad { get; set; }

        public List<Product> FindProducts(double beginOfCaloricity, double endOfCaloricity)
        {
            List<Product> findedProduct = new List<Product>();
            foreach (Product product in ProductSalad)
            {
                if (product.Calories() >= beginOfCaloricity && product.Calories() <= endOfCaloricity)
                {
                    findedProduct.Add(product);
                }
            }
            return findedProduct;
        }

        public double SaladCaloricity()
        {
            double summOfCaloricity = 0;

            if (ProductSalad.Count == 0) return 0;

            foreach (var product in ProductSalad)
            {
                summOfCaloricity += product.Calories();
            }

            return summOfCaloricity;
        }

        public Salad(string saladName)
        {
            this.Name = saladName; 
            this.ProductSalad = new List<Product>();
        }
    }
}
