using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Coktail_Management
{
    public partial class Ajout_Cocktail : Form
    {
        public Ajout_Cocktail()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Utility utility = new Utility();
            utility.Fill_CmbCategory(cmbCategory);
            for (int i = 0; i < 11; i++)
            {
                cmbQuotation.Items.Add(i);
            }
        }

        private void categoryChecked()
        {
            //if ()
            //{
            //    rdbMinuteCockatailAdd.Checked = true;
            //}
            //else
            //{
            //    rdbMinuteCockatailAdd.Checked = false;
            //}
            //if ()
            //{
            //    rdbStunningAdd.Checked = true;
            //}
            //else
            //{
            //    rdbStunningAdd.Checked = false;
            //}
            //if ()
            //{
            //    rdbForCuriousAdd.Checked = true;
            //}
            //else
            //{
            //    rdbForCuriousAdd.Checked = false;
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form myform = new Ajout_Catégorie();
            myform.ShowDialog();
            Utility utility = new Utility();
            utility.Fill_CmbCategory(cmbCategory);
        }

        private void cmbQuotation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
