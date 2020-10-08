namespace InternationalFoodAB
{
    partial class frmAddRecipe
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
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblRecipeDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.txtIngredientName = new System.Windows.Forms.TextBox();
            this.cmdAddIngredient = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.cboRecipeType = new System.Windows.Forms.ComboBox();
            this.lstIngredients = new System.Windows.Forms.ListView();
            this.clmIngredient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIngredientQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtIngredientAmount = new System.Windows.Forms.TextBox();
            this.lblIngredientName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeName.Location = new System.Drawing.Point(237, 191);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(552, 44);
            this.txtRecipeName.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(430, 136);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(197, 37);
            this.lblRecipeName.TabIndex = 1;
            this.lblRecipeName.Text = "Receptnamn";
            // 
            // lblRecipeDescription
            // 
            this.lblRecipeDescription.AutoSize = true;
            this.lblRecipeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeDescription.Location = new System.Drawing.Point(430, 257);
            this.lblRecipeDescription.Name = "lblRecipeDescription";
            this.lblRecipeDescription.Size = new System.Drawing.Size(181, 37);
            this.lblRecipeDescription.TabIndex = 1;
            this.lblRecipeDescription.Text = "Beskrivning";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(237, 309);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(552, 148);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(426, 476);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(193, 37);
            this.lblIngredients.TabIndex = 1;
            this.lblIngredients.Text = "Ingredienser";
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Location = new System.Drawing.Point(374, 537);
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(158, 20);
            this.txtIngredientName.TabIndex = 5;
            // 
            // cmdAddIngredient
            // 
            this.cmdAddIngredient.Location = new System.Drawing.Point(449, 563);
            this.cmdAddIngredient.Name = "cmdAddIngredient";
            this.cmdAddIngredient.Size = new System.Drawing.Size(143, 23);
            this.cmdAddIngredient.TabIndex = 4;
            this.cmdAddIngredient.Text = "Lägg till ingrediens";
            this.cmdAddIngredient.UseVisualStyleBackColor = true;
            this.cmdAddIngredient.Click += new System.EventHandler(this.cmdAddIngredient_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Location = new System.Drawing.Point(916, 624);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(152, 76);
            this.cmdAdd.TabIndex = 7;
            this.cmdAdd.Text = "Lägg till";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cboRecipeType
            // 
            this.cboRecipeType.FormattingEnabled = true;
            this.cboRecipeType.Location = new System.Drawing.Point(429, 72);
            this.cboRecipeType.Name = "cboRecipeType";
            this.cboRecipeType.Size = new System.Drawing.Size(190, 21);
            this.cboRecipeType.TabIndex = 8;
            // 
            // lstIngredients
            // 
            this.lstIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmIngredient,
            this.clmIngredientQuantity});
            this.lstIngredients.HideSelection = false;
            this.lstIngredients.Location = new System.Drawing.Point(237, 597);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(552, 148);
            this.lstIngredients.TabIndex = 9;
            this.lstIngredients.UseCompatibleStateImageBehavior = false;
            this.lstIngredients.View = System.Windows.Forms.View.Details;
            // 
            // clmIngredient
            // 
            this.clmIngredient.Text = "Ingrediens";
            this.clmIngredient.Width = 246;
            // 
            // clmIngredientQuantity
            // 
            this.clmIngredientQuantity.Text = "Mängd";
            this.clmIngredientQuantity.Width = 135;
            // 
            // txtIngredientAmount
            // 
            this.txtIngredientAmount.Location = new System.Drawing.Point(538, 537);
            this.txtIngredientAmount.Name = "txtIngredientAmount";
            this.txtIngredientAmount.Size = new System.Drawing.Size(100, 20);
            this.txtIngredientAmount.TabIndex = 10;
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientName.Location = new System.Drawing.Point(395, 519);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(120, 15);
            this.lblIngredientName.TabIndex = 11;
            this.lblIngredientName.Text = "Ingrediensens namn";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(558, 519);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 15);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Mängd";
            // 
            // frmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 798);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblIngredientName);
            this.Controls.Add(this.txtIngredientAmount);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.cboRecipeType);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.txtIngredientName);
            this.Controls.Add(this.cmdAddIngredient);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblRecipeDescription);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.txtRecipeName);
            this.Name = "frmAddRecipe";
            this.Text = "frmAddRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Label lblRecipeDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.TextBox txtIngredientName;
        private System.Windows.Forms.Button cmdAddIngredient;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.ComboBox cboRecipeType;
        public System.Windows.Forms.ColumnHeader clmIngredient;
        private System.Windows.Forms.ColumnHeader clmIngredientQuantity;
        public System.Windows.Forms.ListView lstIngredients;
        private System.Windows.Forms.TextBox txtIngredientAmount;
        private System.Windows.Forms.Label lblIngredientName;
        private System.Windows.Forms.Label lblAmount;
    }
}