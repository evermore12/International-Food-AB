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
            this.txtRe = new System.Windows.Forms.TextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblRecipeDescription = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.RichTextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.cmdAddIngredient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRe
            // 
            this.txtRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRe.Location = new System.Drawing.Point(232, 87);
            this.txtRe.Name = "txtRe";
            this.txtRe.Size = new System.Drawing.Size(552, 44);
            this.txtRe.TabIndex = 0;
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
            // o
            // 
            this.o.Location = new System.Drawing.Point(232, 205);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(552, 148);
            this.o.TabIndex = 2;
            this.o.Text = "";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(232, 460);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(552, 97);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
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
            this.cmdAddIngredient.Location = new System.Drawing.Point(441, 416);
            this.cmdAddIngredient.Name = "cmdAddIngredient";
            this.cmdAddIngredient.Size = new System.Drawing.Size(143, 23);
            this.cmdAddIngredient.TabIndex = 4;
            this.cmdAddIngredient.Text = "Lägg till ingrediens";
            this.cmdAddIngredient.UseVisualStyleBackColor = true;
            // 
            // frmAddRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 651);
            this.Controls.Add(this.cmdAddIngredient);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.o);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblRecipeDescription);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.txtRe);
            this.Name = "frmAddRecipe";
            this.Text = "frmAddRecipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRe;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Label lblRecipeDescription;
        private System.Windows.Forms.RichTextBox o;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button cmdAddIngredient;
    }
}