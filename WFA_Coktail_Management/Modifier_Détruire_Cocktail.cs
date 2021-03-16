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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Modifier_Détruire_Cocktail_Load(object sender, EventArgs e)
        {
            Utility utility = new Utility();
            utility.fill_CmbCocktail(cmbCocktail);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
