namespace ChefWithWindowsForm
{
    partial class FormWorkWithSalad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveSalad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCaloricity = new System.Windows.Forms.Label();
            this.seeInfo = new System.Windows.Forms.Button();
            this.seeAllProducts = new System.Windows.Forms.Button();
            this.lableRange = new System.Windows.Forms.Label();
            this.textBoxEndRange = new System.Windows.Forms.TextBox();
            this.textBoxBeginRange = new System.Windows.Forms.TextBox();
            this.buttonFindProducts = new System.Windows.Forms.Button();
            this.labelNameSalad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxInfoAboutProducts = new System.Windows.Forms.ListBox();
            this.removeProduct = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.buttonCalorieSorted = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveSalad
            // 
            this.saveSalad.Location = new System.Drawing.Point(324, 313);
            this.saveSalad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.saveSalad.Name = "saveSalad";
            this.saveSalad.Size = new System.Drawing.Size(99, 30);
            this.saveSalad.TabIndex = 0;
            this.saveSalad.Text = "Save salad";
            this.saveSalad.UseVisualStyleBackColor = true;
            this.saveSalad.Click += new System.EventHandler(this.buttonSaveSalad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ChefWithWindowsForm.Properties.Resources.заставка;
            this.groupBox1.Controls.Add(this.buttonCalorieSorted);
            this.groupBox1.Controls.Add(this.labelCaloricity);
            this.groupBox1.Controls.Add(this.seeInfo);
            this.groupBox1.Controls.Add(this.seeAllProducts);
            this.groupBox1.Controls.Add(this.lableRange);
            this.groupBox1.Controls.Add(this.textBoxEndRange);
            this.groupBox1.Controls.Add(this.textBoxBeginRange);
            this.groupBox1.Controls.Add(this.buttonFindProducts);
            this.groupBox1.Controls.Add(this.labelNameSalad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBoxInfoAboutProducts);
            this.groupBox1.Controls.Add(this.removeProduct);
            this.groupBox1.Controls.Add(this.addProduct);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(17, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(406, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // labelCaloricity
            // 
            this.labelCaloricity.AutoSize = true;
            this.labelCaloricity.BackColor = System.Drawing.Color.Transparent;
            this.labelCaloricity.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaloricity.ForeColor = System.Drawing.Color.White;
            this.labelCaloricity.Location = new System.Drawing.Point(216, 182);
            this.labelCaloricity.Name = "labelCaloricity";
            this.labelCaloricity.Size = new System.Drawing.Size(93, 17);
            this.labelCaloricity.TabIndex = 15;
            this.labelCaloricity.Text = "Caloricity: 0";
            // 
            // seeInfo
            // 
            this.seeInfo.Location = new System.Drawing.Point(309, 201);
            this.seeInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seeInfo.Name = "seeInfo";
            this.seeInfo.Size = new System.Drawing.Size(84, 50);
            this.seeInfo.TabIndex = 14;
            this.seeInfo.Text = "Info about product";
            this.seeInfo.UseVisualStyleBackColor = true;
            this.seeInfo.Click += new System.EventHandler(this.buttonSeeInfo_Click);
            // 
            // seeAllProducts
            // 
            this.seeAllProducts.Location = new System.Drawing.Point(219, 201);
            this.seeAllProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.seeAllProducts.Name = "seeAllProducts";
            this.seeAllProducts.Size = new System.Drawing.Size(84, 52);
            this.seeAllProducts.TabIndex = 13;
            this.seeAllProducts.Text = "See all products";
            this.seeAllProducts.UseVisualStyleBackColor = true;
            this.seeAllProducts.Click += new System.EventHandler(this.buttonSeeAllProducts_Click);
            // 
            // lableRange
            // 
            this.lableRange.AutoSize = true;
            this.lableRange.BackColor = System.Drawing.Color.Transparent;
            this.lableRange.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableRange.ForeColor = System.Drawing.Color.White;
            this.lableRange.Location = new System.Drawing.Point(8, 207);
            this.lableRange.Name = "lableRange";
            this.lableRange.Size = new System.Drawing.Size(149, 18);
            this.lableRange.TabIndex = 12;
            this.lableRange.Text = "Range of caloricity:";
            // 
            // textBoxEndRange
            // 
            this.textBoxEndRange.Location = new System.Drawing.Point(87, 228);
            this.textBoxEndRange.Name = "textBoxEndRange";
            this.textBoxEndRange.Size = new System.Drawing.Size(61, 25);
            this.textBoxEndRange.TabIndex = 11;
            this.textBoxEndRange.TextChanged += new System.EventHandler(this.textBoxEndRange_TextChanged);
            // 
            // textBoxBeginRange
            // 
            this.textBoxBeginRange.Location = new System.Drawing.Point(11, 228);
            this.textBoxBeginRange.Name = "textBoxBeginRange";
            this.textBoxBeginRange.Size = new System.Drawing.Size(60, 25);
            this.textBoxBeginRange.TabIndex = 10;
            this.textBoxBeginRange.TextChanged += new System.EventHandler(this.textBoxBeginRange_TextChanged);
            // 
            // buttonFindProducts
            // 
            this.buttonFindProducts.Location = new System.Drawing.Point(11, 150);
            this.buttonFindProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFindProducts.Name = "buttonFindProducts";
            this.buttonFindProducts.Size = new System.Drawing.Size(137, 53);
            this.buttonFindProducts.TabIndex = 8;
            this.buttonFindProducts.Text = "Find product with certain caloricity";
            this.buttonFindProducts.UseVisualStyleBackColor = true;
            this.buttonFindProducts.Click += new System.EventHandler(this.ButtonFindProducts_Click);
            // 
            // labelNameSalad
            // 
            this.labelNameSalad.AutoSize = true;
            this.labelNameSalad.BackColor = System.Drawing.Color.Transparent;
            this.labelNameSalad.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameSalad.Location = new System.Drawing.Point(54, 22);
            this.labelNameSalad.Name = "labelNameSalad";
            this.labelNameSalad.Size = new System.Drawing.Size(45, 17);
            this.labelNameSalad.TabIndex = 6;
            this.labelNameSalad.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of products:";
            // 
            // listBoxInfoAboutProducts
            // 
            this.listBoxInfoAboutProducts.BackColor = System.Drawing.Color.Honeydew;
            this.listBoxInfoAboutProducts.FormattingEnabled = true;
            this.listBoxInfoAboutProducts.ItemHeight = 17;
            this.listBoxInfoAboutProducts.Location = new System.Drawing.Point(219, 55);
            this.listBoxInfoAboutProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBoxInfoAboutProducts.Name = "listBoxInfoAboutProducts";
            this.listBoxInfoAboutProducts.Size = new System.Drawing.Size(172, 123);
            this.listBoxInfoAboutProducts.TabIndex = 4;
            // 
            // removeProduct
            // 
            this.removeProduct.Location = new System.Drawing.Point(11, 92);
            this.removeProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(137, 30);
            this.removeProduct.TabIndex = 3;
            this.removeProduct.Text = "Remove product";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.buttonRemoveProduct_Click);
            // 
            // addProduct
            // 
            this.addProduct.Location = new System.Drawing.Point(11, 55);
            this.addProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(137, 30);
            this.addProduct.TabIndex = 2;
            this.addProduct.Text = "Add product";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(8, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(48, 17);
            this.name.TabIndex = 0;
            this.name.Text = "Name:";
            // 
            // buttonCalorieSorted
            // 
            this.buttonCalorieSorted.Location = new System.Drawing.Point(241, 259);
            this.buttonCalorieSorted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCalorieSorted.Name = "buttonCalorieSorted";
            this.buttonCalorieSorted.Size = new System.Drawing.Size(137, 30);
            this.buttonCalorieSorted.TabIndex = 16;
            this.buttonCalorieSorted.Text = "Calorie Sorted ";
            this.buttonCalorieSorted.UseVisualStyleBackColor = true;
            this.buttonCalorieSorted.Click += new System.EventHandler(this.buttonCalorieSorted_Click);
            // 
            // FormWorkWithSalad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 356);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.saveSalad);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormWorkWithSalad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Work with salad";
            this.Load += new System.EventHandler(this.FormWorkWithSalad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveSalad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxInfoAboutProducts;
        private System.Windows.Forms.Button removeProduct;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Label labelNameSalad;
        private System.Windows.Forms.Button buttonFindProducts;
        private System.Windows.Forms.Label lableRange;
        private System.Windows.Forms.TextBox textBoxEndRange;
        private System.Windows.Forms.TextBox textBoxBeginRange;
        private System.Windows.Forms.Button seeAllProducts;
        private System.Windows.Forms.Button seeInfo;
        private System.Windows.Forms.Label labelCaloricity;
        private System.Windows.Forms.Button buttonCalorieSorted;
    }
}