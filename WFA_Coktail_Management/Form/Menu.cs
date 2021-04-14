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

        private void catégorieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ajouterDesIngredientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frm_add_see_cocktail_ingredients();
            form.ShowDialog();
        }

        private void voirLesCatégoriesEtLesCocktailLiéeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new Les_catégorie_et_leur_cocktails();
            form.ShowDialog();
        }

        private void ajouterDesIngredientsAUnCocktailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new IngredientPourCocktails();
            form.ShowDialog();
        }
    }
}
