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
    public partial class IngredientPourCocktails : Form
    {
        Utility Utility = new Utility();
        public IngredientPourCocktails()
        {
            InitializeComponent();
        }

        private void IngredientPourCocktails_Load(object sender, EventArgs e)
        {
            Utility utility = new Utility();
            utility.Fill_CmbIngredients(cmb_ingredients);
            dgv_cocktailParIngredient.ReadOnly = true;
            utility.fill_dgv_cocktail(dgv_cocktailParIngredient);
        }

        private void cmb_ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
