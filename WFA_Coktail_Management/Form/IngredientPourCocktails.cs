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
            Utility.Fill_CmbIngredients(cmb_ingredients);
        }
    }
}
