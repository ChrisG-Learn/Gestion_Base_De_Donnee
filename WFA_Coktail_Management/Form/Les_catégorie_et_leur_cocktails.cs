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
    public partial class Les_catégorie_et_leur_cocktails : Form
    {
        public Les_catégorie_et_leur_cocktails()
        {
            InitializeComponent();
        }

        private void Les_catégorie_et_leur_cocktails_Load(object sender, EventArgs e)
        {
            FillDGV();
            dgv_category.ReadOnly = true;
            dgv_cocktail.ReadOnly = true;
        }

        private void FillDGV()
        {
            Utility utility = new Utility();
            utility.fill_dgv_category(dgv_category);
            utility.fill_dgv_cocktail(dgv_cocktail);
        }

        private void fill_dgv_cocktail_recherche(int category_id)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            
                using (SqlDataReader Dr = db_Manager.get_Information(category_id, "link_category_cocktail"))
                {
                    Bs.DataSource = Dr;
                    if (Bs.Count > 1)
                    {
                        dgv_cocktail.DataSource = Bs;
                    }
                    else
                        MessageBox.Show("No cocktail with this category");
                }
                dgv_cocktail.RowHeadersVisible = false;
                dgv_cocktail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_category_Click(object sender, EventArgs e)
        {
            dgv_category.CurrentRow.Selected = true;
            int category_id = Convert.ToInt32(dgv_category[0, dgv_category.CurrentRow.Index].Value);
            if (dgv_cocktail.Rows.Count > 0)
            {
                dgv_cocktail.Rows.Clear();
            }
            fill_dgv_cocktail_recherche(category_id);           
        }

        private void dgv_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
