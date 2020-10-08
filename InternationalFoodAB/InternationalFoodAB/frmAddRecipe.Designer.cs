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
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblRecipeDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.cmdAddIngredient = new System.Windows.Forms.Button();
            this.txtIngredient = new System.Windows.Forms.TextBox();
            this.lstIngredients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtRecipe
            // 
            this.txtRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecipe.Location = new System.Drawing.Point(232, 87);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(552, 44);
            this.txtRecipe.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.Location = new System.Drawing.Point(425, 32);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(197, 37);
            this.lblRecipeName.TabIndex = 1;
            this.lblRecipeName.Text = "Receptnamn";
            // 
            // lblRecipeDescription
            // 
            this.lblRecipeDescription.AutoSize = true;
            this.lblRecipeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeDescription.Location = new System.Drawing.Point(425, 153);
            this.lblRecipeDescription.Name = "lblRecipeDescription";
            this.lblRecipeDescription.Size = new System.Drawing.Size(181, 37);
            this.lblRecipeDescription.TabIndex = 1;
            this.lblRecipeDescription.Text = "Beskrivning";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(232, 205);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(552, 148);
            this.txtDescription.TabIndex = 2;
            this.txtDescription.Text = "";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.Location = new System.Drawing.Point(421, 372);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(193, 37);
            this.lblIngredients.TabIndex = 1;
            this.lblIngredients.Text = "Ingredienser";
            // 
            // cmdAddIngredient
            // 
            this.cmdAddIngredient.Location = new System.Drawing.Point(445, 467);
            this.cmdAddIngredient.Name = "cmdAddIngredient";
            this.cmdAddIngredient.Size = new System.Drawing.Size(143, 23);
            this.cmdAddIngredient.TabIndex = 4;
            this.cmdAddIngredient.Text = "Lägg till ingrediens";
            this.cmdAddIngredient.UseVisualStyleBackColor = true;
            this.cmdAddIngredient.Click += new System.EventHandler(this.cmdAddIngredient_Click);
            // 
            // txtIngredient
            // 
            this.txtIngredient.Location = new System.Drawing.Point(466, 441);
            this.txtIngredient.Name = "txtIngredient";
            this.txtIngredient.Size = new System.Drawing.Size(100, 20);
            this.txtIngredient.TabIndex = 5;
            // 
            // lstIngredients
            // 
            this.lstIngredients.FormattingEnabled = true;
            this.lstIngredients.Location = new System.Drawing.Point(232, 511);
            this.lstIngredients.Name = "lstIngredients";
            this.lstIngredients.Size = new System.Drawing.Size(552, 108);
            this.lstIngredients.TabIndex = 6;
            // 
            // frmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 651);
            this.Controls.Add(this.lstIngredients);
            this.Controls.Add(this.txtIngredient);
            this.Controls.Add(this.cmdAddIngredient);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblRecipeDescription);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.txtRecipe);
            this.Name = "frmAddRecipe";
            this.Text = "frmAddRecipe";
            this.Load += new System.EventHandler(this.frmAddRecipe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRecipe;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Label lblRecipeDescription;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button cmdAddIngredient;
        private System.Windows.Forms.TextBox txtIngredient;
        private System.Windows.Forms.ListBox lstIngredients;
    }
}