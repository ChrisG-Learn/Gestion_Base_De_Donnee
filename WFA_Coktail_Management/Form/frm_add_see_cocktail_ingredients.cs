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
            dgv_ingredient.ReadOnly = true;
        }

        private void fill_dgv_ingredient(int cocktail_id)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            string choice = "link_cocktail_ingredient";
            using (SqlDataReader Dr = db_Manager.get_Information(cocktail_id, choice))
            {
                Bs.DataSource = Dr;
                dgv_ingredient.DataSource = Bs;
            }
            dgv_ingredient.RowHeadersVisible = false;
            dgv_ingredient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmb_cocktail_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cocktail_id = Convert.ToInt32(cmb_cocktail.SelectedValue);
            fill_dgv_ingredient(cocktail_id);
        }
    }
}
