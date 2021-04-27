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
        int cocktail_id;

        public frm_add_see_cocktail_ingredients()
        {
            InitializeComponent();
        }

        private void frm_add_see_cocktail_ingredients_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            Utility.fill_CmbCocktail(cmb_cocktail);
            Utility.Fill_CmbIngredients(cmb_ingredients_list);
            cmb_ingredients_list.Enabled = false;
            btn_add_ingredient.Enabled = false;
            txt_quantity.Enabled = false;
            dgv_ingredient.ReadOnly = true;
        }

        private void fill_dgv_ingredient(int cocktail_id)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            string choice = "link_cocktail_ingredient";
            using (SqlDataReader Dr = db_Manager.get_Information(cocktail_id, choice))
            {
                if (Dr.HasRows)
                {
                    Bs.DataSource = Dr;
                    dgv_ingredient.DataSource = Bs;
                }
            }
            dgv_ingredient.RowHeadersVisible = false;
            dgv_ingredient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmb_cocktail_SelectedIndexChanged(object sender, EventArgs e)
        {
            cocktail_id = Convert.ToInt32(cmb_cocktail.SelectedValue);
            fill_dgv_ingredient(cocktail_id);
            Utility.Fill_Cmb_not_in_ingredient(cmb_ingredients_list, cocktail_id);
            cmb_ingredients_list.Enabled = true;
            btn_add_ingredient.Enabled = true;
            txt_quantity.Enabled = true;
        }

        private void btn_add_ingredient_Click(object sender, EventArgs e)
        {
            DB_Manager dB_Manager = new DB_Manager();
            dB_Manager.add_ingredient(cocktail_id, Convert.ToInt32(cmb_ingredients_list.SelectedValue), int.Parse(txt_quantity.Text));
            txt_quantity.Clear();
            refresh();
        }
    }
}
