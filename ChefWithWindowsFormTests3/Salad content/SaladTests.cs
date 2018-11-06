using Microsoft.VisualStudio.TestTools.UnitTesting;
using ChefWithWindowsForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefWithWindowsForm.Tests
{
    [TestClass()]
    public class SaladTests
    {
        [TestMethod()]
        public void FindProductsTest()
        {
            Salad testSalad = new Salad("TestSalad");
            Product product1 = new Cereal("Rice", 900, 12, 56, 5);
            Product product2 = new Vegetable("Onion", 60, 12, 2, 5);
            Product product3 = new Vegetable("Something", 35, 34, 3, 65);
            Product product4 = new Sauce("SourCream", 200, 5, 3, 85);

            testSalad.ProductSalad.Add(product1);
            testSalad.ProductSalad.Add(product2);
            testSalad.ProductSalad.Add(product3);
            testSalad.ProductSalad.Add(product4);
            List<Product> testFindedProduct = testSalad.FindProducts(0, 150);

            List<Product> correctFindedProduct = new List<Product> ();
            correctFindedProduct.Add(product2);
            correctFindedProduct.Add(product3);

            CollectionAssert.AreEqual(correctFindedProduct, testFindedProduct);
        }

        [TestMethod()]
        public void SaladCaloricityTest()
        {
            Salad testSalad = new Salad("TestSalad");
            testSalad.ProductSalad.Add(new Cereal("Rice", 900, 12, 56, 5));          //3096
            testSalad.ProductSalad.Add(new Sauce("SourCream", 200, 5, 3, 85));       //412
            testSalad.ProductSalad.Add(new Vegetable("Onion", 60, 12, 2, 5));        //24.6
            testSalad.ProductSalad.Add(new Vegetable("Something", 35, 34, 3, 65));   //148.05

            double testSaladCaloricity = testSalad.SaladCaloricity();

            double correctSaladCaloricity = 3680.65;

            Assert.AreEqual(correctSaladCaloricity, testSaladCaloricity);
        }
    }
}