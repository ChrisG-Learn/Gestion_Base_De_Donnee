using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WFA_Coktail_Management
{
    public partial class Modifier_Détruire_Cocktail : Form
    {
        public Modifier_Détruire_Cocktail()
        {
            InitializeComponent();
        }

        private void Modifier_Détruire_Cocktail_Load(object sender, EventArgs e)
        {
            FillCmb();
        }

        private void FillCmb() 
        {
            Utility utility = new Utility();
            utility.fill_CmbCocktail(cmbCocktail);
            utility.Fill_CmbCategory(cmbCategory);
            utility.fill_CmbDifficulty(cmbDifficulty);
            for (int i = 0; i < 11; i++)
            {
                cmbQuotation.Items.Add(i);
            }
            cmbQuotation.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCocktailModif_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Manager dB_Manager = new DB_Manager();
                dB_Manager.modify_Cocktail(txtName.Text, cmbDifficulty.SelectedItem.ToString(), int.Parse(cmbQuotation.SelectedItem.ToString()), int.Parse(cmbCategory.SelectedValue.ToString()), int.Parse(cmbCocktail.SelectedValue.ToString()));
                FillCmb();
                txtName.Clear();
                lstAction.Items.Add("Modification sucessfully complete.");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void cmbCocktail_SelectedIndexChanged(object sender, EventArgs e)
        {
            DB_Manager dB_Manager = new DB_Manager();
            int ID = int.Parse(cmbCocktail.SelectedValue.ToString());
            string choice = "Cocktail";
            using (SqlDataReader dataReader = dB_Manager.get_Information(ID, choice))
            {
                if (dataReader.Read())
                {
                    txtName.Text = dataReader["cocktail_name"].ToString();
                    cmbQuotation.SelectedItem = dataReader["quotation"];
                    cmbCategory.SelectedValue = dataReader["category_Id"];
                    cmbDifficulty.SelectedItem = dataReader["difficulty_level"];
                }  
            }

        }

        private void cmbQuotation_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void rdbMinuteCocktail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCocktailDestroy_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Manager dB_Manager = new DB_Manager();
                dB_Manager.destroy_Cocktail(int.Parse(cmbCocktail.SelectedValue.ToString()));
                FillCmb();
                txtName.Clear();
                lstAction.Items.Add("Destruction sucessfully complete");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
    }
}
