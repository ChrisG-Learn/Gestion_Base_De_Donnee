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
            fillcmbCocktailAdd();

        }

        private void fillcmbCocktailAdd()
        {
            Utility utility = new Utility();
            utility.Fill_CmbCategory(cmbCategory);

            for (int i = 0; i < 11; i++)
            {
                cmbQuotation.Items.Add(i);
            }
        }
        private string categoryChecked()
        {
            if (rdbMinuteCockatailAdd.Checked == true && rdbStunningAdd.Checked == false && rdbForCuriousAdd.Checked == false)
            {
                return "minute cocktail";
            }
            else if (rdbStunningAdd.Checked == true && rdbForCuriousAdd.Checked == false && rdbMinuteCockatailAdd.Checked == false)
            {
                return "stunning";
            }
            else if (rdbForCuriousAdd.Checked == true && rdbStunningAdd.Checked == false && rdbMinuteCockatailAdd.Checked == false)
            {
                return "for curious";
            }
            else
            {
                return "";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DB_Manager dB_Manager = new DB_Manager();
            dB_Manager.create_Cocktail(txtName.Text, categoryChecked().ToString(), int.Parse(cmbQuotation.SelectedItem.ToString()), int.Parse(cmbCategory.ValueMember.ToString()));
        }
    }
}
