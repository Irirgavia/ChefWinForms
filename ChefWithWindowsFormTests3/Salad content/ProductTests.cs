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
    public class ProductTests
    {
        [TestMethod()]
        public void CaloriesTest()
        {
            UnknownProduct testProduct = new UnknownProduct("someProduct", 100, 30, 2, 45);
            double testCaloricity = testProduct.Calories();

            double correctCaloricity = 318;

            Assert.AreEqual(correctCaloricity, testCaloricity);
        }

        [TestMethod()]
        public void CompareToTest()
        {
            Salad testSalad = new Salad("TestSalad");
            Product product1 = new Cereal("Rice", 900, 12, 56, 5);
            Product product2 = new Sauce("SourCream", 200, 5, 3, 85);
            Product product3 = new Vegetable("Onion", 60, 12, 2, 5);
            testSalad.ProductSalad.Add(product1);          //3096
            testSalad.ProductSalad.Add(product2);       //508
            testSalad.ProductSalad.Add(product3);        //123.6
            testSalad.ProductSalad.Sort();
            List<Product> testListProduct = testSalad.ProductSalad;

            List<Product> correctListProduct = new List<Product>();
            correctListProduct.Add(product3);
            correctListProduct.Add(product2);
            correctListProduct.Add(product1);

            CollectionAssert.AreEqual(correctListProduct, testListProduct);
        }
    }
}