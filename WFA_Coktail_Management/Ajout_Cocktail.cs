﻿using System;
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
    public partial class Ajout_Cocktail : Form
    {
        DB_Manager dB_Manager = new DB_Manager();
        public Ajout_Cocktail()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbxAjoutCocktail.Items.Clear();
            Utility utility = new Utility();
            utility.Fill_CmbCategory(cmbCategory);
            for (int i = 0; i < 11; i++)
            {
                cmbQuotation.Items.Add(i);
            }
            cmbQuotation.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private string categoryChecked()
        {
            if (rdbMinuteCockatailAdd.Checked == true && rdbStunningAdd.Checked == false && rdbForCuriousAdd.Checked == false)
            {
                return "minute cocktail";
            }
            else
            {
                return "";
            }
            if (rdbStunningAdd.Checked == true && rdbForCuriousAdd.Checked == false && rdbMinuteCockatailAdd.Checked == false)
            {
                return "stunning";
            }
            else
            {
                return "";
            }
            if (rdbForCuriousAdd.Checked = true && rdbStunningAdd.Checked == false && rdbMinuteCockatailAdd.Checked == false)
            {
                return "for curious";
            }
            else
            {
                return "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                dB_Manager.create_Cocktail(txtName.Text, categoryChecked(), int.Parse(cmbQuotation.SelectedItem.ToString()), int.Parse(cmbCategory.SelectedIndex.ToString()));
                lbxAjoutCocktail.Items.Add("Cocktail " + txtName + " crée");
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form myform = new Ajout_Catégorie();
            myform.ShowDialog();
            Utility utility = new Utility();
            utility.Fill_CmbCategory(cmbCategory);
        }

        private void cmbQuotation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
