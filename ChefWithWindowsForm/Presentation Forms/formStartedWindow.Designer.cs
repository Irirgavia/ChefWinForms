namespace ChefWithWindowsForm
{
    partial class FormStartedWindow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNameSalad = new System.Windows.Forms.TextBox();
            this.buttonMakeNewSalad = new System.Windows.Forms.Button();
            this.buttonChooseCreatedBeforeSalads = new System.Windows.Forms.Button();
            this.openFileDialogForChooseSalad = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salad name:";
            this.label1.TextChanged += new System.EventHandler(this.textBoxNameSalad_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::ChefWithWindowsForm.Properties.Resources.заставка;
            this.groupBox1.Controls.Add(this.textBoxNameSalad);
            this.groupBox1.Controls.Add(this.buttonMakeNewSalad);
            this.groupBox1.Controls.Add(this.buttonChooseCreatedBeforeSalads);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(317, 118);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // textBoxNameSalad
            // 
            this.textBoxNameSalad.Location = new System.Drawing.Point(19, 69);
            this.textBoxNameSalad.Name = "textBoxNameSalad";
            this.textBoxNameSalad.Size = new System.Drawing.Size(121, 25);
            this.textBoxNameSalad.TabIndex = 6;
            this.textBoxNameSalad.TextChanged += new System.EventHandler(this.textBoxNameSalad_TextChanged);
            // 
            // buttonMakeNewSalad
            // 
            this.buttonMakeNewSalad.Location = new System.Drawing.Point(177, 22);
            this.buttonMakeNewSalad.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMakeNewSalad.Name = "buttonMakeNewSalad";
            this.buttonMakeNewSalad.Size = new System.Drawing.Size(131, 35);
            this.buttonMakeNewSalad.TabIndex = 3;
            this.buttonMakeNewSalad.Text = "Make new salad";
            this.buttonMakeNewSalad.UseVisualStyleBackColor = true;
            this.buttonMakeNewSalad.Click += new System.EventHandler(this.buttonMakeNewSalad_Click);
            // 
            // buttonChooseCreatedBeforeSalads
            // 
            this.buttonChooseCreatedBeforeSalads.Location = new System.Drawing.Point(177, 65);
            this.buttonChooseCreatedBeforeSalads.Margin = new System.Windows.Forms.Padding(4);
            this.buttonChooseCreatedBeforeSalads.Name = "buttonChooseCreatedBeforeSalads";
            this.buttonChooseCreatedBeforeSalads.Size = new System.Drawing.Size(131, 45);
            this.buttonChooseCreatedBeforeSalads.TabIndex = 4;
            this.buttonChooseCreatedBeforeSalads.Text = "Choose created before salads";
            this.buttonChooseCreatedBeforeSalads.UseVisualStyleBackColor = true;
            this.buttonChooseCreatedBeforeSalads.Click += new System.EventHandler(this.buttonChooseCreatedBeforeSalads_Click);
            // 
            // openFileDialogForChooseSalad
            // 
            this.openFileDialogForChooseSalad.InitialDirectory = "D:\\Documents\\2 курс\\3 семестр\\Projects\\ChefWithWindowsForm\\ChefWithWindowsForm\\Pr" +
    "operties\\All salads";
            // 
            // FormStartedWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 144);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormStartedWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create salad";
            this.Load += new System.EventHandler(this.FormStartedWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonMakeNewSalad;
        private System.Windows.Forms.Button buttonChooseCreatedBeforeSalads;
        private System.Windows.Forms.OpenFileDialog openFileDialogForChooseSalad;
        private System.Windows.Forms.TextBox textBoxNameSalad;
    }
}