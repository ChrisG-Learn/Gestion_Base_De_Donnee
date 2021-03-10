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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Ajout_Cocktail();
            myform.ShowDialog();
        }

        private void modifierDétruireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form myform = new Modifier_Détruire_Cocktail();
            myform.ShowDialog();
        }

        private void ajoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form myform = new Ajout_Catégorie();
            myform.ShowDialog();
        }

        private void modifierDétruireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form myform = new Modifier_Détruire_Catégorie();
            myform.ShowDialog();
        }
    }
}
