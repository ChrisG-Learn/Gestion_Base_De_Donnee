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
            Utility utility = new Utility();
            utility.fill_CmbCocktail(cmbCocktail);
        }

        private void btnCocktailModif_Click(object sender, EventArgs e)
        {

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
                    cmbQuotation.SelectedItem = dataReader["difficulty_level"].ToString();
                    cmbCategory.SelectedItem = dataReader["quotation"].ToString();

                }
            }
        }

        private void cmbQuotation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
