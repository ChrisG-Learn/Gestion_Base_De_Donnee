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
            dgv_cocktailParIngredient.ReadOnly = true;
            utility.fill_dgv_cocktail(dgv_cocktailParIngredient);
        }

        private void fillDgv_Ingredient_reserched(int id)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();

            using (SqlDataReader Dr = db_Manager.
            {
                Bs.DataSource = Dr;
                if (Bs.Count > 1)
                {
                    dgv_cocktailParIngredient.DataSource = Bs;
                }
                else
                    MessageBox.Show("No cocktails whit this ingredient");
            }
            dgv_cocktailParIngredient.RowHeadersVisible = false;
            dgv_cocktailParIngredient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmb_ingredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(cmb_ingredients.SelectedValue);
            fillDgv_Ingredient_reserched(Id);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
