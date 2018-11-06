using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChefWithWindowsForm
{
    class SavingData
    {
        public static Salad MakeSaladIntoTxtFile(string name)
        {
            Salad salad = new Salad(name);

            if (!File.Exists(salad.Name))
            {
                File.Create(salad.Name).Close();
            }

            using (StreamReader file = new StreamReader(salad.Name))
            {
                string line;
                Char delimiter = ' ';

                while ((line = file.ReadLine()) != null)
                {
                    Product product;

                    string[] infoAboutProduct = line.Split(delimiter);

                    product = CreateProduct(infoAboutProduct);
                    salad.ProductSalad.Add(product);
                }
            }
            return salad;
        }

        public static void SaveTxtSalad(Salad salad)
            {
                using (StreamWriter file = new StreamWriter(salad.Name))
                {
                    foreach (var product in salad.ProductSalad)
                    {
                        file.WriteLine(product.ToString(null, null), false, System.Text.Encoding.Default);
                    }
                }
            }

        public static Product CreateProduct(string[] infoAboutProduct)
        {
            Product product;

            if (infoAboutProduct.Length < 6)
            {
                Array.Resize(ref infoAboutProduct, 6);
                infoAboutProduct[3] = "0";
                infoAboutProduct[4] = "0";
                infoAboutProduct[5] = "0";
            }

            switch (infoAboutProduct[0])
            {
                case "Cereal":
                    {
                        product = new Cereal(
                            infoAboutProduct[1],
                            double.Parse(infoAboutProduct[2]),
                            double.Parse(infoAboutProduct[3]),
                            double.Parse(infoAboutProduct[4]),
                            double.Parse(infoAboutProduct[5]));
                        product.TypeProduct = infoAboutProduct[0];
                    }
                    break;
                case "Egg":
                    {
                        product = new Egg(
                            infoAboutProduct[1],
                            double.Parse(infoAboutProduct[2]),
                            double.Parse(infoAboutProduct[3]),
                            double.Parse(infoAboutProduct[4]),
                            double.Parse(infoAboutProduct[5]));
                        product.TypeProduct = infoAboutProduct[0];
                    }
                    break;
                case "Vegetable":
                    {
                        product = new Vegetable(
                            infoAboutProduct[1],
                            double.Parse(infoAboutProduct[2]),
                            double.Parse(infoAboutProduct[3]),
                            double.Parse(infoAboutProduct[4]),
                            double.Parse(infoAboutProduct[5]));
                        product.TypeProduct = infoAboutProduct[0];
                    }
                    break;
                case "Fruit":
                    {
                        product = new Fruit(
                            infoAboutProduct[1],
                            double.Parse(infoAboutProduct[2]),
                            double.Parse(infoAboutProduct[3]),
                            double.Parse(infoAboutProduct[4]),
                            double.Parse(infoAboutProduct[5]));
                        product.TypeProduct = infoAboutProduct[0];
                    }
                    break;
                case "Sauce":
                    {
                        product = new Sauce(
                            infoAboutProduct[1],
                            double.Parse(infoAboutProduct[2]),
                            double.Parse(infoAboutProduct[3]),
                            double.Parse(infoAboutProduct[4]),
                            double.Parse(infoAboutProduct[5]));
                        product.TypeProduct = infoAboutProduct[0];
                    }
                    break;
                case "Seafood":
                    {
                        product = new Seafood(
                            infoAboutProduct[1],
                            double.Parse(infoAboutProduct[2]),
                            double.Parse(infoAboutProduct[3]),
                            double.Parse(infoAboutProduct[4]),
                            double.Parse(infoAboutProduct[5]));
                        product.TypeProduct = infoAboutProduct[0];
                    }
                    break;
                default:
                    {
                        product = new UnknownProduct(
                            infoAboutProduct[1],
                            double.Parse(infoAboutProduct[2]),
                            double.Parse(infoAboutProduct[3]),
                            double.Parse(infoAboutProduct[4]),
                            double.Parse(infoAboutProduct[5]));
                        product.TypeProduct = infoAboutProduct[0];
                    }
                    break;
            }
            return product;
        }
        
        public static void SerializationSalad(Salad salad)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(salad.Name, FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(fs, salad);
            }
        }

        public static Salad DeSerializationSalad(string saladName)
        {
            BinaryFormatter binFormatter = new BinaryFormatter();

            Salad salad = new Salad(saladName);

            using (FileStream fs = new FileStream(salad.Name, FileMode.OpenOrCreate))
            {
                salad = (Salad)binFormatter.Deserialize(fs);
            }

            return salad;
        }
    }
}
