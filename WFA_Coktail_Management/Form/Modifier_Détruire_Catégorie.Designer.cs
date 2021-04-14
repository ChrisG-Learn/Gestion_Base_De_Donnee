
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
            this.SuspendLayout();
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(81, 38);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(0, 17);
            this.lblList.TabIndex = 0;
            this.lblList.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Location = new System.Drawing.Point(447, 38);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(42, 17);
            this.lblChoice.TabIndex = 1;
            this.lblChoice.Text = "Choix";
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 16;
            this.lbxList.Location = new System.Drawing.Point(15, 66);
            this.lbxList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(300, 308);
            this.lbxList.TabIndex = 2;
            // 
            // cmbChoice
            // 
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Location = new System.Drawing.Point(345, 66);
            this.cmbChoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(245, 24);
            this.cmbChoice.TabIndex = 3;
            this.cmbChoice.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(447, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 17);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nom";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(345, 145);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 22);
            this.txtName.TabIndex = 5;
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(385, 183);
            this.btnModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(173, 49);
            this.btnModif.TabIndex = 6;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(385, 256);
            this.btnDestroy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(173, 49);
            this.btnDestroy.TabIndex = 7;
            this.btnDestroy.Text = "Détruire";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // Modifier_Détruire_Catégorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDestroy);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbChoice);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.lblList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}