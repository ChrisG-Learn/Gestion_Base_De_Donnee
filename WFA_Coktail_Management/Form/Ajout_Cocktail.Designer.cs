
namespace WFA_Coktail_Management
{
    partial class Ajout_Cocktail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblQuotation = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbQuotation = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbForCuriousAdd = new System.Windows.Forms.RadioButton();
            this.rdbMinuteCockatailAdd = new System.Windows.Forms.RadioButton();
            this.rdbStunningAdd = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbxAjoutCocktail = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 62);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nom";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(10, 227);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(52, 13);
            this.lblCategorie.TabIndex = 2;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblQuotation
            // 
            this.lblQuotation.AutoSize = true;
            this.lblQuotation.Location = new System.Drawing.Point(9, 188);
            this.lblQuotation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuotation.Name = "lblQuotation";
            this.lblQuotation.Size = new System.Drawing.Size(53, 13);
            this.lblQuotation.TabIndex = 3;
            this.lblQuotation.Text = "Quotation";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(10, 133);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(48, 13);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "Difficulté";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 58);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 20);
            this.txtName.TabIndex = 5;
            // 
            // cmbQuotation
            // 
            this.cmbQuotation.FormattingEnabled = true;
            this.cmbQuotation.Location = new System.Drawing.Point(75, 188);
            this.cmbQuotation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbQuotation.Name = "cmbQuotation";
            this.cmbQuotation.Size = new System.Drawing.Size(239, 21);
            this.cmbQuotation.TabIndex = 6;
            this.cmbQuotation.SelectedIndexChanged += new System.EventHandler(this.cmbQuotation_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(75, 227);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(239, 21);
            this.cmbCategory.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbForCuriousAdd);
            this.groupBox1.Controls.Add(this.rdbMinuteCockatailAdd);
            this.groupBox1.Controls.Add(this.rdbStunningAdd);
            this.groupBox1.Location = new System.Drawing.Point(126, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 93);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rdbForCuriousAdd
            // 
            this.rdbForCuriousAdd.AutoSize = true;
            this.rdbForCuriousAdd.Location = new System.Drawing.Point(28, 61);
            this.rdbForCuriousAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbForCuriousAdd.Name = "rdbForCuriousAdd";
            this.rdbForCuriousAdd.Size = new System.Drawing.Size(100, 17);
            this.rdbForCuriousAdd.TabIndex = 16;
            this.rdbForCuriousAdd.TabStop = true;
            this.rdbForCuriousAdd.Text = "Pour les curieux";
            this.rdbForCuriousAdd.UseVisualStyleBackColor = true;
            // 
            // rdbMinuteCockatailAdd
            // 
            this.rdbMinuteCockatailAdd.AutoSize = true;
            this.rdbMinuteCockatailAdd.Checked = true;
            this.rdbMinuteCockatailAdd.Location = new System.Drawing.Point(28, 17);
            this.rdbMinuteCockatailAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbMinuteCockatailAdd.Name = "rdbMinuteCockatailAdd";
            this.rdbMinuteCockatailAdd.Size = new System.Drawing.Size(97, 17);
            this.rdbMinuteCockatailAdd.TabIndex = 14;
            this.rdbMinuteCockatailAdd.TabStop = true;
            this.rdbMinuteCockatailAdd.Text = "Cocktail minute";
            this.rdbMinuteCockatailAdd.UseVisualStyleBackColor = true;
            // 
            // rdbStunningAdd
            // 
            this.rdbStunningAdd.AutoSize = true;
            this.rdbStunningAdd.Location = new System.Drawing.Point(28, 39);
            this.rdbStunningAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbStunningAdd.Name = "rdbStunningAdd";
            this.rdbStunningAdd.Size = new System.Drawing.Size(62, 17);
            this.rdbStunningAdd.TabIndex = 15;
            this.rdbStunningAdd.TabStop = true;
            this.rdbStunningAdd.Text = "Épatant";
            this.rdbStunningAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 268);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 48);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbxAjoutCocktail
            // 
            this.lbxAjoutCocktail.FormattingEnabled = true;
            this.lbxAjoutCocktail.Location = new System.Drawing.Point(421, 65);
            this.lbxAjoutCocktail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxAjoutCocktail.Name = "lbxAjoutCocktail";
            this.lbxAjoutCocktail.Size = new System.Drawing.Size(126, 251);
            this.lbxAjoutCocktail.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "+";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Ajout_Cocktail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbxAjoutCocktail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbQuotation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblQuotation);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ajout_Cocktail";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblQuotation;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbQuotation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton rdbForCuriousAdd;
        private System.Windows.Forms.RadioButton rdbMinuteCockatailAdd;
        private System.Windows.Forms.RadioButton rdbStunningAdd;
        private System.Windows.Forms.ListBox lbxAjoutCocktail;
        private System.Windows.Forms.Label label2;
    }
}