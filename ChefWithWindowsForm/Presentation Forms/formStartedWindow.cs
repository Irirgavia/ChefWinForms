using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChefWithWindowsForm
{
    public partial class FormStartedWindow : Form
    {
        public FormStartedWindow()
        {
            InitializeComponent();
        }

        private void FormStartedWindow_Load(object sender, EventArgs e)
        {
            buttonMakeNewSalad.Enabled = false;
        }
        
        private void textBoxNameSalad_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNameSalad.Text != string.Empty)
            {
                buttonMakeNewSalad.Enabled = true;
            }
            else
            {
                buttonMakeNewSalad.Enabled = false;
            }
        }

        private void buttonMakeNewSalad_Click(object sender, EventArgs e)
        {
            FormWorkWithSalad formWorkWithSalad = new FormWorkWithSalad(textBoxNameSalad.Text);
            this.Visible = false;
            formWorkWithSalad.ShowDialog();
            this.Visible = true;
        }

        private void buttonChooseCreatedBeforeSalads_Click(object sender, EventArgs e)
        {
            if (openFileDialogForChooseSalad.ShowDialog() == DialogResult.OK)
            {
                string nameSalad = openFileDialogForChooseSalad.FileName;
                Salad salad = SavingData.DeSerializationSalad(nameSalad);

                FormWorkWithSalad formWorkWithSalad = new FormWorkWithSalad(salad);
                this.Visible = false;
                formWorkWithSalad.ShowDialog();
                this.Visible = true;
            }
        }
    }
}
