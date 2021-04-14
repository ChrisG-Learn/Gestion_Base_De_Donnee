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
    public partial class frm_add_see_cocktail_ingredients : Form
    {
        Utility Utility = new Utility();

        public frm_add_see_cocktail_ingredients()
        {
            InitializeComponent();
        }

        private void frm_add_see_cocktail_ingredients_Load(object sender, EventArgs e)
        {
            Utility.fill_CmbCocktail(cmb_cocktail);
            Utility.Fill_CmbIngredients(cmb_ingredients_list);
        }
    }
}
