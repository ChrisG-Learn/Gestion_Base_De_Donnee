
namespace WFA_Coktail_Management
{
    partial class Form1
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
            this.cmbName = new System.Windows.Forms.TextBox();
            this.cmbQutation = new System.Windows.Forms.ComboBox();
            this.cbxMinute = new System.Windows.Forms.CheckBox();
            this.cbxStunning = new System.Windows.Forms.CheckBox();
            this.cbxForCurious = new System.Windows.Forms.CheckBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.lblDifficulty.Click += new System.EventHandler(this.lblDifficulty_Click);
            // 
            // cmbName
            // 
            this.cmbName.Location = new System.Drawing.Point(227, 77);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(317, 22);
            this.cmbName.TabIndex = 5;
            // 
            // cmbQutation
            // 
            this.cmbQutation.FormattingEnabled = true;
            this.cmbQutation.Location = new System.Drawing.Point(227, 237);
            this.cmbQutation.Name = "cmbQutation";
            this.cmbQutation.Size = new System.Drawing.Size(317, 24);
            this.cmbQutation.TabIndex = 6;
            // 
            // cbxMinute
            // 
            this.cbxMinute.AutoSize = true;
            this.cbxMinute.Location = new System.Drawing.Point(17, 26);
            this.cbxMinute.Name = "cbxMinute";
            this.cbxMinute.Size = new System.Drawing.Size(125, 21);
            this.cbxMinute.TabIndex = 8;
            this.cbxMinute.Text = "Cocktail Minute";
            this.cbxMinute.UseVisualStyleBackColor = true;
            // 
            // cbxStunning
            // 
            this.cbxStunning.AutoSize = true;
            this.cbxStunning.Location = new System.Drawing.Point(17, 53);
            this.cbxStunning.Name = "cbxStunning";
            this.cbxStunning.Size = new System.Drawing.Size(79, 21);
            this.cbxStunning.TabIndex = 9;
            this.cbxStunning.Text = "Épatant";
            this.cbxStunning.UseVisualStyleBackColor = true;
            // 
            // cbxForCurious
            // 
            this.cbxForCurious.AutoSize = true;
            this.cbxForCurious.Location = new System.Drawing.Point(17, 80);
            this.cbxForCurious.Name = "cbxForCurious";
            this.cbxForCurious.Size = new System.Drawing.Size(131, 21);
            this.cbxForCurious.TabIndex = 10;
            this.cbxForCurious.Text = "Pour les curieux";
            this.cbxForCurious.UseVisualStyleBackColor = true;
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
            this.groupBox1.Controls.Add(this.cbxMinute);
            this.groupBox1.Controls.Add(this.cbxStunning);
            this.groupBox1.Controls.Add(this.cbxForCurious);
            this.groupBox1.Location = new System.Drawing.Point(295, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 114);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(250, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(270, 59);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbQutation);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.lblQuotation);
            this.Controls.Add(this.lblCategorie);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox cmbName;
        private System.Windows.Forms.ComboBox cmbQutation;
        private System.Windows.Forms.CheckBox cbxMinute;
        private System.Windows.Forms.CheckBox cbxStunning;
        private System.Windows.Forms.CheckBox cbxForCurious;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
    }
}