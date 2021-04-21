
namespace WFA_Coktail_Management
{
    partial class IngredientPourCocktails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_ingredients = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_cocktailParIngredient = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cocktailParIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_ingredients);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche ingredient";
            // 
            // cmb_ingredients
            // 
            this.cmb_ingredients.FormattingEnabled = true;
            this.cmb_ingredients.Location = new System.Drawing.Point(7, 20);
            this.cmb_ingredients.Name = "cmb_ingredients";
            this.cmb_ingredients.Size = new System.Drawing.Size(187, 21);
            this.cmb_ingredients.TabIndex = 0;
            this.cmb_ingredients.SelectionChangeCommitted += new System.EventHandler(this.cmb_ingredients_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_cocktailParIngredient);
            this.groupBox2.Location = new System.Drawing.Point(13, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(570, 351);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cocktail";
            // 
            // dgv_cocktailParIngredient
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            this.dgv_cocktailParIngredient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_cocktailParIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cocktailParIngredient.Location = new System.Drawing.Point(7, 20);
            this.dgv_cocktailParIngredient.Name = "dgv_cocktailParIngredient";
            this.dgv_cocktailParIngredient.RowHeadersWidth = 51;
            this.dgv_cocktailParIngredient.Size = new System.Drawing.Size(557, 325);
            this.dgv_cocktailParIngredient.TabIndex = 0;
            this.dgv_cocktailParIngredient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // IngredientPourCocktails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "IngredientPourCocktails";
            this.Text = "IngredientPourCocktails";
            this.Load += new System.EventHandler(this.IngredientPourCocktails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cocktailParIngredient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_ingredients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_cocktailParIngredient;
    }
}