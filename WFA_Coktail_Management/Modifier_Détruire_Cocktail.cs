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
            DB_Manager.get_Information(int.Parse(cmbCocktail.SelectedIndex.ToString()) , "Cocktail");
        }
    }
}
