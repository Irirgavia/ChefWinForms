using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChefWithWindowsForm
{
    public partial class formInformationAboutProduct : Form
    {
        Cereal cereal = new Cereal();
        Egg egg = new Egg();
        Fruit fruit = new Fruit();
        Sauce sauce = new Sauce();
        Seafood seafood = new Seafood();
        UnknownProduct unknownProduct = new UnknownProduct();
        Vegetable vegetable = new Vegetable();

        Salad salad;
        string[] infoAboutProduct = new string[6];
        bool isSeeInfo;
        int productIndex;

        public formInformationAboutProduct()
        {
            InitializeComponent();
            
            this.isSeeInfo = false;
        }
        public formInformationAboutProduct(int productIndex)
        {
            InitializeComponent();
            
            this.isSeeInfo = true;
            this.productIndex = productIndex;
        }

        private void formInformationAboutProduct_Load(object sender, EventArgs e)
        {
            salad = (this.Owner as FormWorkWithSalad).salad;

            if (!isSeeInfo)
            {
                buttonAdd.Enabled = false;
                buttonSave.Visible = false;
            }
            else
            {
                buttonAdd.Visible = false;
                buttonSave.Enabled = false;

                comboBoxTypeProduct.Text = salad.ProductSalad[productIndex].TypeProduct;
                comboBoxNameProduct.Text = salad.ProductSalad[productIndex].NameProduct;
                textBoxWeightProduct.Text = salad.ProductSalad[productIndex].Weight.ToString();
                textBoxProteins.Text = salad.ProductSalad[productIndex].Proteins.ToString();
                textBoxFats.Text = salad.ProductSalad[productIndex].Fats.ToString();
                textBoxCarbohydrates.Text = salad.ProductSalad[productIndex].Carbohydrates.ToString();
            }
        }

        private void textBoxWeightProduct_TextChanged(object sender, EventArgs e)
        {
            double temp;
            if (comboBoxTypeProduct.Text != string.Empty && comboBoxTypeProduct.Items.Contains(comboBoxTypeProduct.Text) &&
                comboBoxNameProduct.Text != string.Empty &&
                textBoxWeightProduct.Text != string.Empty && Double.TryParse(textBoxWeightProduct.Text, out temp) &&
                textBoxProteins.Text != string.Empty && Double.TryParse(textBoxProteins.Text, out temp) &&
                textBoxFats.Text != string.Empty && Double.TryParse(textBoxFats.Text, out temp) &&
                textBoxCarbohydrates.Text != string.Empty && Double.TryParse(textBoxCarbohydrates.Text, out temp))
            {
                if(!isSeeInfo)
                {
                    buttonAdd.Enabled = true;
                }
                else
                {
                    buttonSave.Enabled = true;
                    
                    salad.ProductSalad[productIndex].Weight = Double.Parse(textBoxWeightProduct.Text);
                }
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void comboBoxNameProduct_TextChanged(object sender, EventArgs e)
        {
            double temp;
            if (comboBoxTypeProduct.Text != string.Empty && comboBoxTypeProduct.Items.Contains(comboBoxTypeProduct.Text) &&
                comboBoxNameProduct.Text != string.Empty &&
                textBoxWeightProduct.Text != string.Empty && Double.TryParse(textBoxWeightProduct.Text, out temp) &&
                textBoxProteins.Text != string.Empty && Double.TryParse(textBoxProteins.Text, out temp) &&
                textBoxFats.Text != string.Empty && Double.TryParse(textBoxFats.Text, out temp) &&
                textBoxCarbohydrates.Text != string.Empty && Double.TryParse(textBoxCarbohydrates.Text, out temp))
            {
                if (!isSeeInfo)
                {
                    buttonAdd.Enabled = true;
                }
                else
                {
                    buttonSave.Enabled = true;
                    
                    salad.ProductSalad[productIndex].NameProduct = comboBoxNameProduct.Text;
                }
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void comboBoxTypeProduct_TextChanged(object sender, EventArgs e)
        {
            comboBoxNameProduct.Items.Clear();

            switch (comboBoxTypeProduct.Text)
            {
                case "Cereal":
                    {
                        comboBoxNameProduct.Text = string.Empty;

                        foreach (var type in cereal.dictionaryTypeProduct.Keys)
                        {
                            comboBoxNameProduct.Items.Add(type);
                        }
                    }
                    break;

                case "Egg":
                    {
                        comboBoxNameProduct.Text = string.Empty;

                        foreach (var type in egg.dictionaryTypeProduct.Keys)
                        {
                            comboBoxNameProduct.Items.Add(type);
                        }
                    }
                    break;

                case "Fruit":
                    {
                        comboBoxNameProduct.Text = string.Empty;

                        foreach (var type in fruit.dictionaryTypeProduct.Keys)
                        {
                            comboBoxNameProduct.Items.Add(type);
                        }
                    }
                    break;

                case "Sauce":
                    {
                        comboBoxNameProduct.Text = string.Empty;

                        foreach (var type in sauce.dictionaryTypeProduct.Keys)
                        {
                            comboBoxNameProduct.Items.Add(type);
                        }
                    }
                    break;

                case "Seafood":
                    {
                        comboBoxNameProduct.Text = string.Empty;

                        foreach (var type in seafood.dictionaryTypeProduct.Keys)
                        {
                            comboBoxNameProduct.Items.Add(type);
                        }
                    }
                    break;

                case "Vegetable":
                    {
                        comboBoxNameProduct.Text = string.Empty;

                        foreach (var type in vegetable.dictionaryTypeProduct.Keys)
                        {
                            comboBoxNameProduct.Items.Add(type);
                        }
                    }
                    break;
            }

            double temp;
            if (comboBoxTypeProduct.Text != string.Empty && comboBoxTypeProduct.Items.Contains(comboBoxTypeProduct.Text) &&
                comboBoxNameProduct.Text != string.Empty &&
                textBoxWeightProduct.Text != string.Empty && Double.TryParse(textBoxWeightProduct.Text, out temp) &&
                textBoxProteins.Text != string.Empty && Double.TryParse(textBoxProteins.Text, out temp) &&
                textBoxFats.Text != string.Empty && Double.TryParse(textBoxFats.Text, out temp) &&
                textBoxCarbohydrates.Text != string.Empty && Double.TryParse(textBoxCarbohydrates.Text, out temp))
            {
                if (!isSeeInfo)
                {
                    buttonAdd.Enabled = true;
                }
                else
                {
                    buttonSave.Enabled = true;

                    salad.ProductSalad[productIndex].TypeProduct = comboBoxTypeProduct.Text;
                }
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void textBoxProteins_TextChanged(object sender, EventArgs e)
        {
            double temp;
            if (comboBoxTypeProduct.Text != string.Empty && comboBoxTypeProduct.Items.Contains(comboBoxTypeProduct.Text) &&
                comboBoxNameProduct.Text != string.Empty &&
                textBoxWeightProduct.Text != string.Empty && Double.TryParse(textBoxWeightProduct.Text, out temp) &&
                textBoxProteins.Text != string.Empty && Double.TryParse(textBoxProteins.Text, out temp) &&
                textBoxFats.Text != string.Empty && Double.TryParse(textBoxFats.Text, out temp) &&
                textBoxCarbohydrates.Text != string.Empty && Double.TryParse(textBoxCarbohydrates.Text, out temp))
            {
                if (!isSeeInfo)
                {
                    buttonAdd.Enabled = true;
                }
                else
                {
                    buttonSave.Enabled = true;
                    
                    salad.ProductSalad[productIndex].Proteins = Double.Parse(textBoxProteins.Text);
                }
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void textBoxFats_TextChanged(object sender, EventArgs e)
        {
            double temp;
            if (comboBoxTypeProduct.Text != string.Empty && comboBoxTypeProduct.Items.Contains(comboBoxTypeProduct.Text) &&
                comboBoxNameProduct.Text != string.Empty &&
                textBoxWeightProduct.Text != string.Empty && Double.TryParse(textBoxWeightProduct.Text, out temp) &&
                textBoxProteins.Text != string.Empty && Double.TryParse(textBoxProteins.Text, out temp) &&
                textBoxFats.Text != string.Empty && Double.TryParse(textBoxFats.Text, out temp) &&
                textBoxCarbohydrates.Text != string.Empty && Double.TryParse(textBoxCarbohydrates.Text, out temp))
            {
                if (!isSeeInfo)
                {
                    buttonAdd.Enabled = true;
                }
                else
                {
                    buttonSave.Enabled = true;
                    
                    salad.ProductSalad[productIndex].Fats = Double.Parse(textBoxFats.Text);
                }
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void textBoxCarbohydrates_TextChanged(object sender, EventArgs e)
        {
            double temp;
            if (comboBoxTypeProduct.Text != string.Empty && comboBoxTypeProduct.Items.Contains(comboBoxTypeProduct.Text) &&
                comboBoxNameProduct.Text != string.Empty &&
                textBoxWeightProduct.Text != string.Empty && Double.TryParse(textBoxWeightProduct.Text, out temp) &&
                textBoxProteins.Text != string.Empty && Double.TryParse(textBoxProteins.Text, out temp) &&
                textBoxFats.Text != string.Empty && Double.TryParse(textBoxFats.Text, out temp) &&
                textBoxCarbohydrates.Text != string.Empty && Double.TryParse(textBoxCarbohydrates.Text, out temp))
            {
                if (!isSeeInfo)
                {
                    buttonAdd.Enabled = true;
                }
                else
                {
                    buttonSave.Enabled = true;
                    
                    salad.ProductSalad[productIndex].Carbohydrates = Double.Parse(textBoxCarbohydrates.Text);
                }
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonSave.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            infoAboutProduct[0] = comboBoxTypeProduct.Text;
            infoAboutProduct[1] = comboBoxNameProduct.Text;
            infoAboutProduct[2] = textBoxWeightProduct.Text;
            infoAboutProduct[3] = textBoxProteins.Text;
            infoAboutProduct[4] = textBoxFats.Text;
            infoAboutProduct[5] = textBoxCarbohydrates.Text;
            
            (this.Owner as FormWorkWithSalad).salad.ProductSalad.Add(SavingData.CreateProduct(infoAboutProduct));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            (this.Owner as FormWorkWithSalad).salad = salad;
        }
    }
}
