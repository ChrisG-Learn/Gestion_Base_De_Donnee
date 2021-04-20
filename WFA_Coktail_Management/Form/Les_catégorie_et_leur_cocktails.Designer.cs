
namespace WFA_Coktail_Management
{
    partial class Les_catégorie_et_leur_cocktails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblCocktails = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.dgv_cocktail = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cocktail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblCategorie.Location = new System.Drawing.Point(22, 18);
            this.lblCategorie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(83, 15);
            this.lblCategorie.TabIndex = 0;
            this.lblCategorie.Text = "Les Catégorie";
            // 
            // lblCocktails
            // 
            this.lblCocktails.AutoSize = true;
            this.lblCocktails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCocktails.Location = new System.Drawing.Point(22, 202);
            this.lblCocktails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCocktails.Name = "lblCocktails";
            this.lblCocktails.Size = new System.Drawing.Size(88, 15);
            this.lblCocktails.TabIndex = 1;
            this.lblCocktails.Text = "Leurs cocktails";
            // 
            // dgv_category
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            this.dgv_category.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_category.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(25, 35);
            this.dgv_category.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 51;
            this.dgv_category.RowTemplate.Height = 24;
            this.dgv_category.Size = new System.Drawing.Size(564, 165);
            this.dgv_category.TabIndex = 2;
            // 
            // dgv_cocktail
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            this.dgv_cocktail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cocktail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cocktail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cocktail.Location = new System.Drawing.Point(25, 219);
            this.dgv_cocktail.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_cocktail.Name = "dgv_cocktail";
            this.dgv_cocktail.RowHeadersWidth = 51;
            this.dgv_cocktail.RowTemplate.Height = 24;
            this.dgv_cocktail.Size = new System.Drawing.Size(564, 165);
            this.dgv_cocktail.TabIndex = 3;
            this.dgv_cocktail.Click += new System.EventHandler(this.dgv_cocktail_Click);
            // 
            // Les_catégorie_et_leur_cocktails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 392);
            this.Controls.Add(this.dgv_cocktail);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.lblCocktails);
            this.Controls.Add(this.lblCategorie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Les_catégorie_et_leur_cocktails";
            this.Text = "Les_catégorie_et_leur_cocktails";
            this.Load += new System.EventHandler(this.Les_catégorie_et_leur_cocktails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cocktail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblCocktails;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.DataGridView dgv_cocktail;
    }
}