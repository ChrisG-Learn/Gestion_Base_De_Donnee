
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(140, 82);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nom";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Location = new System.Drawing.Point(140, 285);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(69, 17);
            this.lblCategorie.TabIndex = 2;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblQuotation
            // 
            this.lblQuotation.AutoSize = true;
            this.lblQuotation.Location = new System.Drawing.Point(139, 237);
            this.lblQuotation.Name = "lblQuotation";
            this.lblQuotation.Size = new System.Drawing.Size(70, 17);
            this.lblQuotation.TabIndex = 3;
            this.lblQuotation.Text = "Quotation";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Location = new System.Drawing.Point(140, 170);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(62, 17);
            this.lblDifficulty.TabIndex = 4;
            this.lblDifficulty.Text = "Difficulté";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(227, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(317, 22);
            this.txtName.TabIndex = 5;
            // 
            // cmbQuotation
            // 
            this.cmbQuotation.FormattingEnabled = true;
            this.cmbQuotation.Location = new System.Drawing.Point(227, 237);
            this.cmbQuotation.Name = "cmbQuotation";
            this.cmbQuotation.Size = new System.Drawing.Size(317, 24);
            this.cmbQuotation.TabIndex = 6;
            this.cmbQuotation.SelectedIndexChanged += new System.EventHandler(this.cmbQuotation_SelectedIndexChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(227, 285);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(317, 24);
            this.cmbCategory.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbForCuriousAdd);
            this.groupBox1.Controls.Add(this.rdbMinuteCockatailAdd);
            this.groupBox1.Controls.Add(this.rdbStunningAdd);
            this.groupBox1.Location = new System.Drawing.Point(295, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // rdbForCuriousAdd
            // 
            this.rdbForCuriousAdd.AutoSize = true;
            this.rdbForCuriousAdd.Location = new System.Drawing.Point(38, 75);
            this.rdbForCuriousAdd.Name = "rdbForCuriousAdd";
            this.rdbForCuriousAdd.Size = new System.Drawing.Size(130, 21);
            this.rdbForCuriousAdd.TabIndex = 16;
            this.rdbForCuriousAdd.TabStop = true;
            this.rdbForCuriousAdd.Text = "Pour les curieux";
            this.rdbForCuriousAdd.UseVisualStyleBackColor = true;
            // 
            // rdbMinuteCockatailAdd
            // 
            this.rdbMinuteCockatailAdd.AutoSize = true;
            this.rdbMinuteCockatailAdd.Checked = true;
            this.rdbMinuteCockatailAdd.Location = new System.Drawing.Point(38, 21);
            this.rdbMinuteCockatailAdd.Name = "rdbMinuteCockatailAdd";
            this.rdbMinuteCockatailAdd.Size = new System.Drawing.Size(124, 21);
            this.rdbMinuteCockatailAdd.TabIndex = 14;
            this.rdbMinuteCockatailAdd.TabStop = true;
            this.rdbMinuteCockatailAdd.Text = "Cocktail minute";
            this.rdbMinuteCockatailAdd.UseVisualStyleBackColor = true;
            // 
            // rdbStunningAdd
            // 
            this.rdbStunningAdd.AutoSize = true;
            this.rdbStunningAdd.Location = new System.Drawing.Point(38, 48);
            this.rdbStunningAdd.Name = "rdbStunningAdd";
            this.rdbStunningAdd.Size = new System.Drawing.Size(78, 21);
            this.rdbStunningAdd.TabIndex = 15;
            this.rdbStunningAdd.TabStop = true;
            this.rdbStunningAdd.Text = "Épatant";
            this.rdbStunningAdd.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(250, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 59);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Ajout_Cocktail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbQuotation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblQuotation);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblName);
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
    }
}