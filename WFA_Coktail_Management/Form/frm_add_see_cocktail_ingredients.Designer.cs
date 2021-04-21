namespace WFA_Coktail_Management
{
    partial class frm_add_see_cocktail_ingredients
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_cocktail = new System.Windows.Forms.ComboBox();
            this.cmb_ingredients_list = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_ingredient = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_add_ingredient = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_cocktail_list = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingredient)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_cocktail);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Cocktail";
            // 
            // cmb_cocktail
            // 
            this.cmb_cocktail.FormattingEnabled = true;
            this.cmb_cocktail.Location = new System.Drawing.Point(7, 20);
            this.cmb_cocktail.Name = "cmb_cocktail";
            this.cmb_cocktail.Size = new System.Drawing.Size(215, 21);
            this.cmb_cocktail.TabIndex = 0;
            this.cmb_cocktail.SelectedIndexChanged += new System.EventHandler(this.cmb_cocktail_SelectedIndexChanged);
            // 
            // cmb_ingredients_list
            // 
            this.cmb_ingredients_list.FormattingEnabled = true;
            this.cmb_ingredients_list.Location = new System.Drawing.Point(6, 19);
            this.cmb_ingredients_list.Name = "cmb_ingredients_list";
            this.cmb_ingredients_list.Size = new System.Drawing.Size(203, 21);
            this.cmb_ingredients_list.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_ingredient);
            this.groupBox2.Location = new System.Drawing.Point(13, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 219);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ingredient And Quantity";
            // 
            // dgv_ingredient
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.dgv_ingredient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ingredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ingredient.Location = new System.Drawing.Point(6, 20);
            this.dgv_ingredient.Name = "dgv_ingredient";
            this.dgv_ingredient.Size = new System.Drawing.Size(280, 193);
            this.dgv_ingredient.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_add_ingredient);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.cmb_ingredients_list);
            this.groupBox3.Location = new System.Drawing.Point(13, 298);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Ingredient";
            // 
            // btn_add_ingredient
            // 
            this.btn_add_ingredient.Location = new System.Drawing.Point(7, 47);
            this.btn_add_ingredient.Name = "btn_add_ingredient";
            this.btn_add_ingredient.Size = new System.Drawing.Size(279, 41);
            this.btn_add_ingredient.TabIndex = 3;
            this.btn_add_ingredient.Text = "Add ingredient";
            this.btn_add_ingredient.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(216, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 2;
            // 
            // cmb_cocktail_list
            // 
            this.cmb_cocktail_list.FormattingEnabled = true;
            this.cmb_cocktail_list.Location = new System.Drawing.Point(7, 20);
            this.cmb_cocktail_list.Name = "cmb_cocktail_list";
            this.cmb_cocktail_list.Size = new System.Drawing.Size(215, 21);
            this.cmb_cocktail_list.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(6, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // frm_add_see_cocktail_ingredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_add_see_cocktail_ingredients";
            this.Text = "frm_add_see_cocktail_ingredients";
            this.Load += new System.EventHandler(this.frm_add_see_cocktail_ingredients_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ingredient)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_cocktail;
        private System.Windows.Forms.ComboBox cmb_ingredients_list;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_ingredient;
        private System.Windows.Forms.Button btn_add_ingredient;
        private System.Windows.Forms.ComboBox cmb_cocktail_list;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}