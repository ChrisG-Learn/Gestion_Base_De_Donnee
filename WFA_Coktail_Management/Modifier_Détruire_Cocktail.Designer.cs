
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbForCurious = new System.Windows.Forms.RadioButton();
            this.rdbStunning = new System.Windows.Forms.RadioButton();
            this.rdbMinuteCocktail = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 76);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 22);
            this.txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbForCurious);
            this.groupBox1.Controls.Add(this.rdbStunning);
            this.groupBox1.Controls.Add(this.rdbMinuteCocktail);
            this.groupBox1.Location = new System.Drawing.Point(293, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(171, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // rdbForCurious
            // 
            this.rdbForCurious.AutoSize = true;
            this.rdbForCurious.Location = new System.Drawing.Point(31, 79);
            this.rdbForCurious.Name = "rdbForCurious";
            this.rdbForCurious.Size = new System.Drawing.Size(130, 21);
            this.rdbForCurious.TabIndex = 2;
            this.rdbForCurious.TabStop = true;
            this.rdbForCurious.Text = "Pour les curieux";
            this.rdbForCurious.UseVisualStyleBackColor = true;
            // 
            // rdbStunning
            // 
            this.rdbStunning.AutoSize = true;
            this.rdbStunning.Location = new System.Drawing.Point(31, 52);
            this.rdbStunning.Name = "rdbStunning";
            this.rdbStunning.Size = new System.Drawing.Size(78, 21);
            this.rdbStunning.TabIndex = 1;
            this.rdbStunning.TabStop = true;
            this.rdbStunning.Text = "Épatant";
            this.rdbStunning.UseVisualStyleBackColor = true;
            // 
            // rdbMinuteCocktail
            // 
            this.rdbMinuteCocktail.AutoSize = true;
            this.rdbMinuteCocktail.Location = new System.Drawing.Point(31, 25);
            this.rdbMinuteCocktail.Name = "rdbMinuteCocktail";
            this.rdbMinuteCocktail.Size = new System.Drawing.Size(131, 21);
            this.rdbMinuteCocktail.TabIndex = 0;
            this.rdbMinuteCocktail.TabStop = true;
            this.rdbMinuteCocktail.Text = "Cocktail minutes";
            this.rdbMinuteCocktail.UseVisualStyleBackColor = true;
            // 
            // cmbCocktail
            // 
            this.cmbCocktail.FormattingEnabled = true;
            this.cmbCocktail.Location = new System.Drawing.Point(211, 34);
            this.cmbCocktail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCocktail.Name = "cmbCocktail";
            this.cmbCocktail.Size = new System.Drawing.Size(327, 24);
            this.cmbCocktail.TabIndex = 2;
            this.cmbCocktail.SelectedIndexChanged += new System.EventHandler(this.cmbCocktail_SelectedIndexChanged);
            // 
            // cmbQuotation
            // 
            this.cmbQuotation.FormattingEnabled = true;
            this.cmbQuotation.Location = new System.Drawing.Point(227, 244);
            this.cmbQuotation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbQuotation.Name = "cmbQuotation";
            this.cmbQuotation.Size = new System.Drawing.Size(291, 24);
            this.cmbQuotation.TabIndex = 3;
            this.cmbQuotation.SelectedIndexChanged += new System.EventHandler(this.cmbQuotation_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(227, 297);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(291, 24);
            this.cmbCategory.TabIndex = 4;
            // 
            // btnCocktailModif
            // 
            this.btnCocktailModif.Location = new System.Drawing.Point(176, 354);
            this.btnCocktailModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCocktailModif.Name = "btnCocktailModif";
            this.btnCocktailModif.Size = new System.Drawing.Size(188, 57);
            this.btnCocktailModif.TabIndex = 5;
            this.btnCocktailModif.Text = "Modifier";
            this.btnCocktailModif.UseVisualStyleBackColor = true;
            this.btnCocktailModif.Click += new System.EventHandler(this.btnCocktailModif_Click);
            // 
            // btnCocktailDestroy
            // 
            this.btnCocktailDestroy.Location = new System.Drawing.Point(392, 354);
            this.btnCocktailDestroy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCocktailDestroy.Name = "btnCocktailDestroy";
            this.btnCocktailDestroy.Size = new System.Drawing.Size(188, 57);
            this.btnCocktailDestroy.TabIndex = 6;
            this.btnCocktailDestroy.Text = "Détruire";
            this.btnCocktailDestroy.UseVisualStyleBackColor = true;
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(83, 38);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(113, 17);
            this.lblChoice.TabIndex = 7;
            this.lblChoice.Text = "Choix de cocktail";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(117, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nom";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(105, 169);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(62, 17);
            this.lblDifficulty.TabIndex = 9;
            this.lblDifficulty.Text = "Difficulté";
            // 
            // lblQuotation
            // 
            this.lblQuotation.AutoSize = true;
            this.lblQuotation.Location = new System.Drawing.Point(105, 244);
            this.lblQuotation.Name = "lblQuotation";
            this.lblQuotation.Size = new System.Drawing.Size(70, 17);
            this.lblQuotation.TabIndex = 10;
            this.lblQuotation.Text = "Quotation";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(107, 300);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 17);
            this.lblCategory.TabIndex = 11;
            this.lblCategory.Text = "Catégorie";
            // 
            // Modifier_Détruire_Cocktail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Modifier_Détruire_Cocktail";
            this.Text = "Modifier_Détruire";
            this.Load += new System.EventHandler(this.Modifier_Détruire_Cocktail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.RadioButton rdbForCurious;
        private System.Windows.Forms.RadioButton rdbStunning;
        private System.Windows.Forms.RadioButton rdbMinuteCocktail;
    }
}