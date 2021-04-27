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
            fill
            utility.fill_dgv_cocktail(dgv_cocktailParIngredient);
            dgv_cocktailParIngredient.Rows.Clear();
            
        }

        private void fillDgv_Ingredient_reserched(int id)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            string choice = "LinkIngredient";
            using (SqlDataReader Dr = db_Manager.get_Information(id, choice))
            {
                if (Dr.HasRows)
                {
                    Bs.DataSource = Dr;
                    dgv_cocktailParIngredient.DataSource = Bs;
                }
            }
            dgv_cocktailParIngredient.RowHeadersVisible = false;
            dgv_cocktailParIngredient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_cocktailParIngredient.ReadOnly = true;
        }

        private void cmb_ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(cmb_ingredients.SelectedValue);
            dgv_cocktailParIngredient.Rows.Clear();
            fillDgv_Ingredient_reserched(Id);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
