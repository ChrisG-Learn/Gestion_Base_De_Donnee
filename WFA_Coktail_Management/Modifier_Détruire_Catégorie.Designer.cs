
namespace WFA_Coktail_Management
{
    partial class Modifier_Détruire_Catégorie
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
            this.lblList = new System.Windows.Forms.Label();
            this.lblChoice = new System.Windows.Forms.Label();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnActualise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(103, 31);
            this.lblList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(120, 13);
            this.lblList.TabIndex = 0;
            this.lblList.Text = "Catégorie déja existante";
            this.lblList.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(335, 31);
            this.lblChoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(33, 13);
            this.lblChoice.TabIndex = 1;
            this.lblChoice.Text = "Choix";
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.Location = new System.Drawing.Point(93, 54);
            this.lbxList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(144, 251);
            this.lbxList.TabIndex = 2;
            // 
            // cmbChoice
            // 
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Location = new System.Drawing.Point(259, 54);
            this.cmbChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(185, 21);
            this.cmbChoice.TabIndex = 3;
            this.cmbChoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(335, 91);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nom";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(259, 118);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 5;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(289, 149);
            this.btnModif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(130, 40);
            this.btnModif.TabIndex = 6;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(289, 208);
            this.btnDestroy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(130, 40);
            this.btnDestroy.TabIndex = 7;
            this.btnDestroy.Text = "Détruire";
            this.btnDestroy.UseVisualStyleBackColor = true;
            // 
            // btnActualise
            // 
            this.btnActualise.Location = new System.Drawing.Point(289, 265);
            this.btnActualise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualise.Name = "btnActualise";
            this.btnActualise.Size = new System.Drawing.Size(130, 40);
            this.btnActualise.TabIndex = 8;
            this.btnActualise.Text = "Actualiser la liste";
            this.btnActualise.UseVisualStyleBackColor = true;
            this.btnActualise.Click += new System.EventHandler(this.btnActualise_Click);
            // 
            // Modifier_Détruire_Catégorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnActualise);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbChoice);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.lblList);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Modifier_Détruire_Catégorie";
            this.Text = "Modifier_Détruire_Catégorie";
            this.Load += new System.EventHandler(this.Modifier_Détruire_Catégorie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.ComboBox cmbChoice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnActualise;
    }
}