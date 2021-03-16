
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
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(250, 58);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(222, 20);
            this.txtCategory.TabIndex = 0;
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.Location = new System.Drawing.Point(72, 58);
            this.lbxList.Margin = new System.Windows.Forms.Padding(2);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(155, 264);
            this.lbxList.TabIndex = 1;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(272, 107);
            this.btnAddCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(174, 40);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Ajouter une catégorie";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblCategoryExisting
            // 
            this.lblCategoryExisting.AutoSize = true;
            this.lblCategoryExisting.Location = new System.Drawing.Point(88, 34);
            this.lblCategoryExisting.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategoryExisting.Name = "lblCategoryExisting";
            this.lblCategoryExisting.Size = new System.Drawing.Size(120, 13);
            this.lblCategoryExisting.TabIndex = 3;
            this.lblCategoryExisting.Text = "Catégorie déja existante";
            // 
            // lblNameAdd
            // 
            this.lblNameAdd.AutoSize = true;
            this.lblNameAdd.Location = new System.Drawing.Point(292, 34);
            this.lblNameAdd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameAdd.Name = "lblNameAdd";
            this.lblNameAdd.Size = new System.Drawing.Size(140, 13);
            this.lblNameAdd.TabIndex = 4;
            this.lblNameAdd.Text = "Ajouter un nom de catégorie";
            // 
            // Ajout_Catégorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblNameAdd);
            this.Controls.Add(this.lblCategoryExisting);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lbxList);
            this.Controls.Add(this.txtCategory);
            this.Margin = new System.Windows.Forms.Padding(2);
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
    }
}