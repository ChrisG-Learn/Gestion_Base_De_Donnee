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

        public void FillCmbChoice(ComboBox Cmb)
        {
            DB_Manager db_Manager = new DB_Manager();
            BindingSource Bs = new BindingSource();
            using (SqlDataReader Dr = db_Manager.list_Cocktail_Category("0"))
            {
                Bs.DataSource = Dr;
                Cmb.ValueMember = "category_Id";
                Cmb.DisplayMember = "category";
                Cmb.DataSource = Bs;
            }
        }

    }
}
