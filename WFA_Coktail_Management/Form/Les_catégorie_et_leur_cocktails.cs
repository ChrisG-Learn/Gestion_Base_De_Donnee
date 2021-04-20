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

        private void dgv_cocktail_Click(object sender, EventArgs e)
        {
            dgv_cocktail.CurrentRow.Selected = true;
            int cocktail_id = Convert.ToInt32(dgv_cocktail[0, dgv_cocktail.CurrentRow.Index].Value);
        }
    }
}
