
namespace WFA_Coktail_Management
{
    partial class Modifier_Détruire_Cocktail
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbCocktail = new System.Windows.Forms.ComboBox();
            this.cmbQuotation = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnCocktailModif = new System.Windows.Forms.Button();
            this.btnCocktailDestroy = new System.Windows.Forms.Button();
            this.lblChoice = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblQuotation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lstAction = new System.Windows.Forms.ListBox();
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(170, 62);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 20);
            this.txtName.TabIndex = 0;
            // 
            // cmbCocktail
            // 
            this.cmbCocktail.FormattingEnabled = true;
            this.cmbCocktail.Location = new System.Drawing.Point(158, 28);
            this.cmbCocktail.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCocktail.Name = "cmbCocktail";
            this.cmbCocktail.Size = new System.Drawing.Size(246, 21);
            this.cmbCocktail.TabIndex = 2;
            this.cmbCocktail.SelectedIndexChanged += new System.EventHandler(this.cmbCocktail_SelectedIndexChanged);
            // 
            // cmbQuotation
            // 
            this.cmbQuotation.FormattingEnabled = true;
            this.cmbQuotation.Location = new System.Drawing.Point(170, 198);
            this.cmbQuotation.Margin = new System.Windows.Forms.Padding(2);
            this.cmbQuotation.Name = "cmbQuotation";
            this.cmbQuotation.Size = new System.Drawing.Size(219, 21);
            this.cmbQuotation.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(170, 241);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(219, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // btnCocktailModif
            // 
            this.btnCocktailModif.Location = new System.Drawing.Point(132, 288);
            this.btnCocktailModif.Margin = new System.Windows.Forms.Padding(2);
            this.btnCocktailModif.Name = "btnCocktailModif";
            this.btnCocktailModif.Size = new System.Drawing.Size(141, 46);
            this.btnCocktailModif.TabIndex = 5;
            this.btnCocktailModif.Text = "Modifier";
            this.btnCocktailModif.UseVisualStyleBackColor = true;
            this.btnCocktailModif.Click += new System.EventHandler(this.btnCocktailModif_Click);
            // 
            // btnCocktailDestroy
            // 
            this.btnCocktailDestroy.Location = new System.Drawing.Point(294, 288);
            this.btnCocktailDestroy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCocktailDestroy.Name = "btnCocktailDestroy";
            this.btnCocktailDestroy.Size = new System.Drawing.Size(141, 46);
            this.btnCocktailDestroy.TabIndex = 6;
            this.btnCocktailDestroy.Text = "Détruire";
            this.btnCocktailDestroy.UseVisualStyleBackColor = true;
            this.btnCocktailDestroy.Click += new System.EventHandler(this.btnCocktailDestroy_Click);
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(62, 31);
            this.lblChoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(88, 13);
            this.lblChoice.TabIndex = 7;
            this.lblChoice.Text = "Choix de cocktail";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(88, 64);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nom";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(79, 137);
            this.lblDifficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(48, 13);
            this.lblDifficulty.TabIndex = 9;
            this.lblDifficulty.Text = "Difficulté";
            // 
            // lblQuotation
            // 
            this.lblQuotation.AutoSize = true;
            this.lblQuotation.Location = new System.Drawing.Point(79, 198);
            this.lblQuotation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuotation.Name = "lblQuotation";
            this.lblQuotation.Size = new System.Drawing.Size(53, 13);
            this.lblQuotation.TabIndex = 10;
            this.lblQuotation.Text = "Quotation";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(80, 244);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Catégorie";
            // 
            // lstAction
            // 
            this.lstAction.FormattingEnabled = true;
            this.lstAction.Location = new System.Drawing.Point(440, 31);
            this.lstAction.Name = "lstAction";
            this.lstAction.Size = new System.Drawing.Size(148, 303);
            this.lstAction.TabIndex = 12;
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(170, 134);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(219, 21);
            this.cmbDifficulty.TabIndex = 13;
            // 
            // Modifier_Détruire_Cocktail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.cmbDifficulty);
            this.Controls.Add(this.lstAction);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblQuotation);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.btnCocktailDestroy);
            this.Controls.Add(this.btnCocktailModif);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbQuotation);
            this.Controls.Add(this.cmbCocktail);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Modifier_Détruire_Cocktail";
            this.Text = "Modifier_Détruire";
            this.Load += new System.EventHandler(this.Modifier_Détruire_Cocktail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbCocktail;
        private System.Windows.Forms.ComboBox cmbQuotation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnCocktailModif;
        private System.Windows.Forms.Button btnCocktailDestroy;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblQuotation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ListBox lstAction;
        private System.Windows.Forms.ComboBox cmbDifficulty;
    }
}