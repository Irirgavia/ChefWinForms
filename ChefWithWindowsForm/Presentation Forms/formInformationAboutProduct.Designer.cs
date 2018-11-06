namespace ChefWithWindowsForm
{
    partial class formInformationAboutProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProteins = new System.Windows.Forms.TextBox();
            this.textBoxFats = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCarbohydrates = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWeightProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTypeProduct = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNameProduct = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(195, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Proteins:";
            // 
            // textBoxProteins
            // 
            this.textBoxProteins.Location = new System.Drawing.Point(199, 42);
            this.textBoxProteins.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxProteins.Name = "textBoxProteins";
            this.textBoxProteins.Size = new System.Drawing.Size(132, 25);
            this.textBoxProteins.TabIndex = 3;
            this.textBoxProteins.TextChanged += new System.EventHandler(this.textBoxProteins_TextChanged);
            // 
            // textBoxFats
            // 
            this.textBoxFats.Location = new System.Drawing.Point(199, 95);
            this.textBoxFats.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFats.Name = "textBoxFats";
            this.textBoxFats.Size = new System.Drawing.Size(132, 25);
            this.textBoxFats.TabIndex = 5;
            this.textBoxFats.TextChanged += new System.EventHandler(this.textBoxFats_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(195, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fats:";
            // 
            // textBoxCarbohydrates
            // 
            this.textBoxCarbohydrates.Location = new System.Drawing.Point(199, 145);
            this.textBoxCarbohydrates.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCarbohydrates.Name = "textBoxCarbohydrates";
            this.textBoxCarbohydrates.Size = new System.Drawing.Size(132, 25);
            this.textBoxCarbohydrates.TabIndex = 7;
            this.textBoxCarbohydrates.TextChanged += new System.EventHandler(this.textBoxCarbohydrates_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(195, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Carbohydrates:";
            // 
            // textBoxWeightProduct
            // 
            this.textBoxWeightProduct.Location = new System.Drawing.Point(12, 146);
            this.textBoxWeightProduct.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxWeightProduct.Name = "textBoxWeightProduct";
            this.textBoxWeightProduct.Size = new System.Drawing.Size(132, 25);
            this.textBoxWeightProduct.TabIndex = 9;
            this.textBoxWeightProduct.TextChanged += new System.EventHandler(this.textBoxWeightProduct_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(8, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Weight:";
            // 
            // comboBoxTypeProduct
            // 
            this.comboBoxTypeProduct.FormattingEnabled = true;
            this.comboBoxTypeProduct.Items.AddRange(new object[] {
            "Cereal",
            "Egg",
            "Fruit",
            "Sause",
            "Seafood",
            "Vegetable",
            "UnknownProduct"});
            this.comboBoxTypeProduct.Location = new System.Drawing.Point(12, 42);
            this.comboBoxTypeProduct.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTypeProduct.Name = "comboBoxTypeProduct";
            this.comboBoxTypeProduct.Size = new System.Drawing.Size(132, 25);
            this.comboBoxTypeProduct.TabIndex = 10;
            this.comboBoxTypeProduct.TextChanged += new System.EventHandler(this.comboBoxTypeProduct_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(8, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Type of product:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ChefWithWindowsForm.Properties.Resources.заставка;
            this.groupBox1.Controls.Add(this.comboBoxNameProduct);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxTypeProduct);
            this.groupBox1.Controls.Add(this.textBoxWeightProduct);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxProteins);
            this.groupBox1.Controls.Add(this.textBoxCarbohydrates);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxFats);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(348, 192);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxNameProduct
            // 
            this.comboBoxNameProduct.FormattingEnabled = true;
            this.comboBoxNameProduct.Location = new System.Drawing.Point(12, 97);
            this.comboBoxNameProduct.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxNameProduct.Name = "comboBoxNameProduct";
            this.comboBoxNameProduct.Size = new System.Drawing.Size(132, 25);
            this.comboBoxNameProduct.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(264, 216);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(16, 216);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 30);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // formInformationAboutProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 259);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formInformationAboutProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information about product";
            this.Load += new System.EventHandler(this.formInformationAboutProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProteins;
        private System.Windows.Forms.TextBox textBoxFats;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCarbohydrates;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWeightProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTypeProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxNameProduct;
    }
}