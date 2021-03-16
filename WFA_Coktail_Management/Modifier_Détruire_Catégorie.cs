using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFA_Coktail_Management
{
    public partial class Modifier_Détruire_Catégorie : Form
    {
        

        public Modifier_Détruire_Catégorie()
        {
            InitializeComponent();

        }
        private void Modifier_Détruire_Catégorie_Load(object sender, EventArgs e)
        {
            fill_Cmb_List();
            btnDestroy.Enabled = false;
            btnModif.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DB_Manager dB_Manager = new DB_Manager();
                int ID = int.Parse(cmbChoice.SelectedValue.ToString());
                string choice = "Category";
                using (SqlDataReader dataReader = dB_Manager.get_Information(ID, choice))
                {
                    if (dataReader.Read())
                    {
                        txtName.Text = dataReader["category"].ToString();
                    }
                }
                btnDestroy.Enabled = true;
                btnModif.Enabled = true;
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Manager dB_Manager = new DB_Manager();
                dB_Manager.modify_Category(txtName.Text, int.Parse(cmbChoice.SelectedValue.ToString()));
                fill_Cmb_List();
                empty_TextBox();
                lbxList.Items.Add("Modification sucessfully complete.");
            }
            catch(SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void fill_Cmb_List()
        {
            try
            {
                Utility utility = new Utility();
                utility.Fill_CmbCategory(cmbChoice);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void empty_TextBox()
        {
            txtName.Clear();
        }

        private void btnActualise_Click(object sender, EventArgs e)
        {
            fill_Cmb_List();
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            try
            {
                DB_Manager dB_Manager = new DB_Manager();
                dB_Manager.destroy_Category(int.Parse(cmbChoice.SelectedValue.ToString()));
                fill_Cmb_List();
                empty_TextBox();
                lbxList.Items.Add("Destruction sucessfully complete");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }
    }
}
