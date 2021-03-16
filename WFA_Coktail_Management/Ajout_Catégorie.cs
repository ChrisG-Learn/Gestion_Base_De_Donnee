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
    public partial class Ajout_Catégorie : Form
    {
        DB_Manager dB_Manager = new DB_Manager();

        public Ajout_Catégorie()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                dB_Manager.create_Category(txtCategory.Text);
                lbxList.Items.Add("Category " + txtCategory + " created");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
    }
}
