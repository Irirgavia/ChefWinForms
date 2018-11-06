using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChefWithWindowsForm
{
    public partial class FormWorkWithSalad : Form
    {
        bool isClickFind;
        bool isShowFindedRroducts;

        List<Product> findedProduct;
        public Salad salad;

        void UpdateInfoBoxAboutProduct(List<Product> product)
        {
            listBoxInfoAboutProducts.Items.Clear();
            foreach (Product someProduct in product)
            {
                listBoxInfoAboutProducts.Items.Add(someProduct.NameProduct);
            }

            labelCaloricity.Text = "Caloricity: " + salad.SaladCaloricity().ToString();
        }

        public FormWorkWithSalad(string saladName)
        {
            InitializeComponent();
            salad = new Salad(saladName);
        }
        public FormWorkWithSalad(Salad salad)
        {
            InitializeComponent();
            this.salad = salad;
        }

        private void FormWorkWithSalad_Load(object sender, EventArgs e)
        {
            labelNameSalad.Text = salad.Name;

            isClickFind = false;
            isShowFindedRroducts = false;

            lableRange.Visible = false;
            textBoxBeginRange.Visible = false;
            textBoxEndRange.Visible = false;

            labelCaloricity.Text = "Caloricity: " + salad.SaladCaloricity().ToString();
            findedProduct = new List<Product>();

            UpdateInfoBoxAboutProduct(salad.ProductSalad);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            lableRange.Visible = false;
            textBoxBeginRange.Visible = false;
            textBoxBeginRange.Text = string.Empty;
            textBoxEndRange.Visible = false;
            textBoxEndRange.Text = string.Empty;

            isClickFind = false;

            buttonFindProducts.Enabled = true;

            formInformationAboutProduct formAddProduct = new formInformationAboutProduct();
            formAddProduct.Owner = this;
            this.Visible = false;
            formAddProduct.ShowDialog();
            this.Visible = true;

            UpdateInfoBoxAboutProduct(salad.ProductSalad);
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            lableRange.Visible = false;
            textBoxBeginRange.Visible = false;
            textBoxBeginRange.Text = string.Empty;
            textBoxEndRange.Visible = false;
            textBoxEndRange.Text = string.Empty;

            isClickFind = false;

            buttonFindProducts.Enabled = true;

            if (listBoxInfoAboutProducts.SelectedIndex >= 0 && listBoxInfoAboutProducts.SelectedIndex < listBoxInfoAboutProducts.Items.Count)
            {
                Product product;

                if (isShowFindedRroducts)
                {
                    product = findedProduct[listBoxInfoAboutProducts.SelectedIndex];

                    salad.ProductSalad.Remove(product);
                    findedProduct.Remove(product);

                    UpdateInfoBoxAboutProduct(findedProduct);
                }
                else
                {
                    product = salad.ProductSalad[listBoxInfoAboutProducts.SelectedIndex];

                    salad.ProductSalad.Remove(product);

                    UpdateInfoBoxAboutProduct(salad.ProductSalad);
                }
            }
        }

        private void ButtonFindProducts_Click(object sender, EventArgs e)
        {
            lableRange.Visible = true;
            textBoxBeginRange.Visible = true;
            textBoxEndRange.Visible = true;

            if (isClickFind)
            {
                findedProduct = salad.FindProducts(Double.Parse(textBoxBeginRange.Text), Double.Parse(textBoxEndRange.Text));

                UpdateInfoBoxAboutProduct(findedProduct);

                isShowFindedRroducts = true;
            }
            else
            {
                isClickFind = true;
                buttonFindProducts.Enabled = false;
            }
        }

        private void buttonSaveSalad_Click(object sender, EventArgs e)
        {
            buttonFindProducts.Enabled = true;

            SavingData.SerializationSalad(salad);
        }

        private void buttonSeeAllProducts_Click(object sender, EventArgs e)
        {
            lableRange.Visible = false;
            textBoxBeginRange.Visible = false;
            textBoxBeginRange.Text = string.Empty;
            textBoxEndRange.Visible = false;
            textBoxEndRange.Text = string.Empty;

            isClickFind = false;
            buttonFindProducts.Enabled = true;

            UpdateInfoBoxAboutProduct(salad.ProductSalad);
        }

        private void buttonSeeInfo_Click(object sender, EventArgs e)
        {
            lableRange.Visible = false;
            textBoxBeginRange.Visible = false;
            textBoxBeginRange.Text = string.Empty;
            textBoxEndRange.Visible = false;
            textBoxEndRange.Text = string.Empty;

            buttonFindProducts.Enabled = true;

            if (listBoxInfoAboutProducts.SelectedIndex >= 0 && listBoxInfoAboutProducts.SelectedIndex < listBoxInfoAboutProducts.Items.Count) 
            {
                formInformationAboutProduct formInfoProduct = new formInformationAboutProduct(listBoxInfoAboutProducts.SelectedIndex);
                formInfoProduct.Owner = this;
                this.Visible = false;
                formInfoProduct.ShowDialog();
                this.Visible = true;

                UpdateInfoBoxAboutProduct(salad.ProductSalad);
            }
        }

        private void textBoxBeginRange_TextChanged(object sender, EventArgs e)
        {
            double temp;
            if (Double.TryParse(textBoxBeginRange.Text, out temp) && Double.TryParse(textBoxEndRange.Text, out temp) && Double.Parse(textBoxBeginRange.Text)>=0 && Double.Parse(textBoxEndRange.Text) >= 0 &&
                textBoxBeginRange.Text != string.Empty && textBoxEndRange.Text != string.Empty)
            {
                buttonFindProducts.Enabled = true;
            }
            else
            {
                buttonFindProducts.Enabled = false;
            }
        }

        private void textBoxEndRange_TextChanged(object sender, EventArgs e)
        {
            double temp;
            if (Double.TryParse(textBoxBeginRange.Text, out temp) && Double.TryParse(textBoxEndRange.Text, out temp) && Double.Parse(textBoxBeginRange.Text) >= 0 && Double.Parse(textBoxEndRange.Text) >= 0 &&
                textBoxBeginRange.Text != string.Empty && textBoxEndRange.Text != string.Empty)
            {
                buttonFindProducts.Enabled = true;
            }
            else
            {
                buttonFindProducts.Enabled = false;
            }
        }

        private void buttonCalorieSorted_Click(object sender, EventArgs e)
        {
            salad.ProductSalad.Sort();
            UpdateInfoBoxAboutProduct(salad.ProductSalad);
        }
    }
}
