using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace WFA_Coktail_Management
{
    class Utility
    {

        public void Fill_CmbCategory(ComboBox cmb)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            string choice = "Category";
            using (SqlDataReader Dr = db_Manager.list_Cocktail_Category(choice))
            {
                Bs.DataSource = Dr;
                cmb.ValueMember = "category_Id";
                cmb.DisplayMember = "info";
                cmb.DataSource = Bs;
            }
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void fill_CmbCocktail(ComboBox cmb)
        {
            DB_Manager dB_Manager = new DB_Manager();
            BindingSource bindingSource = new BindingSource();
            string choice = "Cocktail";
            using (SqlDataReader sqlDataReader = dB_Manager.list_Cocktail_Category(choice))
            {
                bindingSource.DataSource = sqlDataReader;
                cmb.ValueMember = "cocktail_Id";
                cmb.DisplayMember = "info";
                cmb.DataSource = bindingSource;
            }
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void fill_CmbDifficulty(ComboBox cmb)
        {
            cmb.Items.Add("minute cocktail");
            cmb.Items.Add("for curious");
            cmb.Items.Add("stunning");
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void Fill_CmbIngredients(ComboBox cmb)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            using (SqlDataReader Dr = db_Manager.list_Cocktail_Category("Ingredients"))
            {
                Bs.DataSource = Dr;
                cmb.ValueMember = "ID_ingredient";
                cmb.DisplayMember = "info";
                cmb.DataSource = Bs;
            }
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void fill_dgv_category(DataGridView dataGridView)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            string choice = "Category";
            using (SqlDataReader Dr = db_Manager.list_Cocktail_Category(choice))
            {
                Bs.DataSource = Dr;
                dataGridView.DataSource = Bs;
            }
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns["category_Id"].Visible = false;
        }

        public void fill_dgv_ingredients(DataGridView dataGridView)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            string choice = "Ingredients";
            using (SqlDataReader Dr = db_Manager.list_Cocktail_Category(choice))
            {
                Bs.DataSource = Dr;
                dataGridView.DataSource = Bs;
            }
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns["ID_ingredient"].Visible = false;
        }

        public void fill_dgv_cocktail(DataGridView dataGridView)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            string choice = "Cocktail";
            using (SqlDataReader Dr = db_Manager.list_Cocktail_Category(choice))
            {
                Bs.DataSource = Dr;
                dataGridView.DataSource = Bs;
            }
            dataGridView.RowHeadersVisible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Columns["cocktail_Id"].Visible = false;
            dataGridView.Columns["category_Id"].Visible = false;
        }
    }
}
