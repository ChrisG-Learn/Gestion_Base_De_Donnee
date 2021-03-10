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
            Utility utility = new Utility();
            utility.FillCmbChoice(cmbChoice);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
