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

        public void Fill_lstCategory(ListBox lst)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            string choice = "Category";
            using (SqlDataReader Dr = db_Manager.list_Cocktail_Category(choice))
            {
                Bs.DataSource = Dr;
                lst.DataSource = Bs;
            }
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
    }
}
