
namespace WFA_Coktail_Management
{
    partial class Ajout_Catégorie
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
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lbxList = new System.Windows.Forms.ListBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblCategoryExisting = new System.Windows.Forms.Label();
            this.lblNameAdd = new System.Windows.Forms.Label();
            this.btnActualise = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(333, 72);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(295, 22);
            this.txtCategory.TabIndex = 0;
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.ItemHeight = 16;
            this.lbxList.Location = new System.Drawing.Point(96, 72);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(205, 324);
            this.lbxList.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(363, 132);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(232, 49);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Ajouter une catégorie";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // lblCategoryExisting
            // 
            this.lblCategoryExisting.AutoSize = true;
            this.lblCategoryExisting.Location = new System.Drawing.Point(118, 42);
            this.lblCategoryExisting.Name = "lblCategoryExisting";
            this.lblCategoryExisting.Size = new System.Drawing.Size(160, 17);
            this.lblCategoryExisting.TabIndex = 3;
            this.lblCategoryExisting.Text = "Catégorie déja existante";
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(389, 42);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(187, 17);
            this.lblNameAdd.TabIndex = 4;
            this.lblNameAdd.Text = "Ajouter un nom de catégorie";
            // 
            // btnActualise
            // 
            this.btnActualise.Location = new System.Drawing.Point(363, 202);
            this.btnActualise.Name = "btnActualise";
            this.btnActualise.Size = new System.Drawing.Size(231, 47);
            this.btnActualise.TabIndex = 5;
            this.btnActualise.Text = "Actualiser la liste";
            this.btnActualise.UseVisualStyleBackColor = true;
            // 
            // Ajout_Catégorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualise);
            this.Controls.Add(this.lblNameAdd);
            this.Controls.Add(this.lblCategoryExisting);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.txtCategory);
            this.Name = "Ajout_Catégorie";
            this.Text = "Ajout_Catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label lblCategoryExisting;
        private System.Windows.Forms.Label lblNameAdd;
        private System.Windows.Forms.Button btnActualise;
    }
}