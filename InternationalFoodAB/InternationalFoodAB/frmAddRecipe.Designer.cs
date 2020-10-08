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
            this.lblRecipeType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipeName.Location = new System.Drawing.Point(332, 90);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(355, 38);
            this.txtRecipeName.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(82, 93);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(168, 31);
            this.lblRecipeName.TabIndex = 1;
            this.lblRecipeName.Text = "Receptnamn";
            // 
            // lblRecipeDescription
            // 
            this.lblRecipeDescription.AutoSize = true;
            this.lblRecipeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeDescription.Location = new System.Drawing.Point(82, 169);
            this.lblRecipeDescription.Name = "lblRecipeDescription";
            this.lblRecipeDescription.Size = new System.Drawing.Size(155, 31);
            this.lblRecipeDescription.TabIndex = 1;
            this.lblRecipeDescription.Text = "Beskrivning";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(332, 169);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(355, 148);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(82, 347);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(165, 31);
            this.lblIngredients.TabIndex = 1;
            this.lblIngredients.Text = "Ingredienser";
            // 
            // txtIngredientName
            // 
            this.txtIngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientName.Location = new System.Drawing.Point(332, 347);
            this.txtIngredientName.Multiline = true;
            this.txtIngredientName.Name = "txtIngredientName";
            this.txtIngredientName.Size = new System.Drawing.Size(227, 44);
            this.txtIngredientName.TabIndex = 5;
            // 
            // cmdAddIngredient
            // 
            this.cmdAddIngredient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddIngredient.Location = new System.Drawing.Point(332, 397);
            this.cmdAddIngredient.Name = "cmdAddIngredient";
            this.cmdAddIngredient.Size = new System.Drawing.Size(227, 30);
            this.cmdAddIngredient.TabIndex = 4;
            this.cmdAddIngredient.Text = "Lägg till ingrediens i listan nedan";
            this.cmdAddIngredient.UseVisualStyleBackColor = true;
            this.cmdAddIngredient.Click += new System.EventHandler(this.cmdAddIngredient_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(535, 634);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(152, 44);
            this.cmdAdd.TabIndex = 7;
            this.cmdAdd.Text = "Lägg till";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cboRecipeType
            // 
            this.cboRecipeType.FormattingEnabled = true;
            this.cboRecipeType.Location = new System.Drawing.Point(332, 43);
            this.cboRecipeType.Name = "cboRecipeType";
            this.cboRecipeType.Size = new System.Drawing.Size(186, 21);
            this.cboRecipeType.TabIndex = 8;
            // 
            // lstIngredients
            // 
            this.lstIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmIngredient,
            this.clmIngredientQuantity});
            this.lstIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstIngredients.HideSelection = false;
            this.lstIngredients.Location = new System.Drawing.Point(89, 471);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(598, 148);
            this.lstIngredients.TabIndex = 9;
            this.lstIngredients.UseCompatibleStateImageBehavior = false;
            this.lstIngredients.View = System.Windows.Forms.View.Details;
            // 
            // clmIngredient
            // 
            this.clmIngredient.Text = "Ingrediens";
            this.clmIngredient.Width = 327;
            // 
            // clmIngredientQuantity
            // 
            this.clmIngredientQuantity.Text = "Mängd";
            this.clmIngredientQuantity.Width = 228;
            // 
            // txtIngredientAmount
            // 
            this.txtIngredientAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientAmount.Location = new System.Drawing.Point(576, 347);
            this.txtIngredientAmount.Multiline = true;
            this.txtIngredientAmount.Name = "txtIngredientAmount";
            this.txtIngredientAmount.Size = new System.Drawing.Size(111, 44);
            this.txtIngredientAmount.TabIndex = 10;
            // 
            // lblIngredientName
            // 
            this.lblIngredientName.AutoSize = true;
            this.lblIngredientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientName.Location = new System.Drawing.Point(329, 329);
            this.lblIngredientName.Name = "lblIngredientName";
            this.lblIngredientName.Size = new System.Drawing.Size(129, 16);
            this.lblIngredientName.TabIndex = 11;
            this.lblIngredientName.Text = "Ingrediensens namn";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(573, 329);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(50, 16);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Mängd";
            // 
            // lblRecipeType
            // 
            this.lblRecipeType.AutoSize = true;
            this.lblRecipeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeType.Location = new System.Drawing.Point(82, 33);
            this.lblRecipeType.Name = "lblRecipeType";
            this.lblRecipeType.Size = new System.Drawing.Size(138, 31);
            this.lblRecipeType.TabIndex = 13;
            this.lblRecipeType.Text = "Recepttyp";
            // 
            // frmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 731);
            this.Controls.Add(this.lblRecipeType);
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
            this.Text = "Lägg till recept";
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
        private System.Windows.Forms.Label lblRecipeType;
    }
}