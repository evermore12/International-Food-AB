namespace InternationalFoodAB
{
    partial class frmMainForm
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
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.picSoup = new System.Windows.Forms.PictureBox();
            this.picSalad = new System.Windows.Forms.PictureBox();
            this.picMeat = new System.Windows.Forms.PictureBox();
            this.picFish = new System.Windows.Forms.PictureBox();
            this.picCake = new System.Windows.Forms.PictureBox();
            this.cmdSearch = new System.Windows.Forms.Button();
            this.txtSearchWord = new System.Windows.Forms.TextBox();
            this.grbRecipe = new System.Windows.Forms.GroupBox();
            this.lstRecipes = new System.Windows.Forms.ListView();
            this.clnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdLogIn = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.cmdAddRecipe = new System.Windows.Forms.Button();
            this.grbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCake)).BeginInit();
            this.grbRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.picSoup);
            this.grbSearch.Controls.Add(this.picSalad);
            this.grbSearch.Controls.Add(this.picMeat);
            this.grbSearch.Controls.Add(this.picFish);
            this.grbSearch.Controls.Add(this.picCake);
            this.grbSearch.Controls.Add(this.cmdSearch);
            this.grbSearch.Controls.Add(this.txtSearchWord);
            this.grbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearch.Location = new System.Drawing.Point(131, 106);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(581, 144);
            this.grbSearch.TabIndex = 0;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Sök efter recept";
            // 
            // picSoup
            // 
            this.picSoup.Image = global::InternationalFoodAB.Properties.Resources.Soup;
            this.picSoup.InitialImage = null;
            this.picSoup.Location = new System.Drawing.Point(325, 72);
            this.picSoup.Name = "picSoup";
            this.picSoup.Size = new System.Drawing.Size(56, 56);
            this.picSoup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSoup.TabIndex = 7;
            this.picSoup.TabStop = false;
            this.picSoup.Click += new System.EventHandler(this.picSoup_Click);
            // 
            // picSalad
            // 
            this.picSalad.Image = global::InternationalFoodAB.Properties.Resources.Salad;
            this.picSalad.InitialImage = null;
            this.picSalad.Location = new System.Drawing.Point(251, 73);
            this.picSalad.Name = "picSalad";
            this.picSalad.Size = new System.Drawing.Size(56, 56);
            this.picSalad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSalad.TabIndex = 6;
            this.picSalad.TabStop = false;
            this.picSalad.Click += new System.EventHandler(this.picSalad_Click);
            // 
            // picMeat
            // 
            this.picMeat.Image = global::InternationalFoodAB.Properties.Resources.Meat;
            this.picMeat.InitialImage = null;
            this.picMeat.Location = new System.Drawing.Point(177, 72);
            this.picMeat.Name = "picMeat";
            this.picMeat.Size = new System.Drawing.Size(56, 56);
            this.picMeat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMeat.TabIndex = 5;
            this.picMeat.TabStop = false;
            this.picMeat.Click += new System.EventHandler(this.picMeat_Click);
            // 
            // picFish
            // 
            this.picFish.Image = global::InternationalFoodAB.Properties.Resources.Fish;
            this.picFish.InitialImage = null;
            this.picFish.Location = new System.Drawing.Point(103, 72);
            this.picFish.Name = "picFish";
            this.picFish.Size = new System.Drawing.Size(56, 56);
            this.picFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFish.TabIndex = 4;
            this.picFish.TabStop = false;
            this.picFish.Click += new System.EventHandler(this.picFish_Click);
            // 
            // picCake
            // 
            this.picCake.Image = global::InternationalFoodAB.Properties.Resources.Cake;
            this.picCake.InitialImage = null;
            this.picCake.Location = new System.Drawing.Point(29, 72);
            this.picCake.Name = "picCake";
            this.picCake.Size = new System.Drawing.Size(56, 56);
            this.picCake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCake.TabIndex = 3;
            this.picCake.TabStop = false;
            this.picCake.Click += new System.EventHandler(this.picCake_Click);
            // 
            // cmdSearch
            // 
            this.cmdSearch.Location = new System.Drawing.Point(404, 85);
            this.cmdSearch.Name = "cmdSearch";
            this.cmdSearch.Size = new System.Drawing.Size(154, 33);
            this.cmdSearch.TabIndex = 2;
            this.cmdSearch.Text = "Sök efter recept";
            this.cmdSearch.UseVisualStyleBackColor = true;
            this.cmdSearch.Click += new System.EventHandler(this.cmdSearch_Click);
            // 
            // txtSearchWord
            // 
            this.txtSearchWord.Location = new System.Drawing.Point(27, 35);
            this.txtSearchWord.Multiline = true;
            this.txtSearchWord.Name = "txtSearchWord";
            this.txtSearchWord.Size = new System.Drawing.Size(531, 25);
            this.txtSearchWord.TabIndex = 1;
            // 
            // grbRecipe
            // 
            this.grbRecipe.Controls.Add(this.lstRecipes);
            this.grbRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRecipe.Location = new System.Drawing.Point(131, 266);
            this.grbRecipe.Name = "grbRecipe";
            this.grbRecipe.Size = new System.Drawing.Size(581, 303);
            this.grbRecipe.TabIndex = 1;
            this.grbRecipe.TabStop = false;
            this.grbRecipe.Text = "Recepter";
            // 
            // lstRecipes
            // 
            this.lstRecipes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnType,
            this.clnTitle});
            this.lstRecipes.HideSelection = false;
            this.lstRecipes.Location = new System.Drawing.Point(27, 35);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(531, 246);
            this.lstRecipes.TabIndex = 0;
            this.lstRecipes.UseCompatibleStateImageBehavior = false;
            this.lstRecipes.View = System.Windows.Forms.View.Details;
            // 
            // clnType
            // 
            this.clnType.Text = "Typ";
            this.clnType.Width = 204;
            // 
            // clnTitle
            // 
            this.clnTitle.Text = "Titel";
            this.clnTitle.Width = 293;
            // 
            // cmdLogIn
            // 
            this.cmdLogIn.Location = new System.Drawing.Point(604, 28);
            this.cmdLogIn.Name = "cmdLogIn";
            this.cmdLogIn.Size = new System.Drawing.Size(108, 54);
            this.cmdLogIn.TabIndex = 2;
            this.cmdLogIn.Text = "Logga in";
            this.cmdLogIn.UseVisualStyleBackColor = true;
            this.cmdLogIn.Click += new System.EventHandler(this.cmdLogIn_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccount.Location = new System.Drawing.Point(45, 28);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(70, 13);
            this.lblAccount.TabIndex = 3;
            this.lblAccount.Text = "Ej inloggad";
            // 
            // cmdAddRecipe
            // 
            this.cmdAddRecipe.Location = new System.Drawing.Point(480, 28);
            this.cmdAddRecipe.Name = "cmdAddRecipe";
            this.cmdAddRecipe.Size = new System.Drawing.Size(108, 54);
            this.cmdAddRecipe.TabIndex = 4;
            this.cmdAddRecipe.Text = "Lägg till nytt recept";
            this.cmdAddRecipe.UseVisualStyleBackColor = true;
            this.cmdAddRecipe.Click += new System.EventHandler(this.cmdAddRecipe_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 606);
            this.Controls.Add(this.cmdAddRecipe);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.cmdLogIn);
            this.Controls.Add(this.grbRecipe);
            this.Controls.Add(this.grbSearch);
            this.Name = "frmMainForm";
            this.Text = "Recepter";
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSoup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCake)).EndInit();
            this.grbRecipe.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.TextBox txtSearchWord;
        public System.Windows.Forms.PictureBox picCake;
        public System.Windows.Forms.PictureBox picFish;
        public System.Windows.Forms.PictureBox picSoup;
        public System.Windows.Forms.PictureBox picSalad;
        public System.Windows.Forms.PictureBox picMeat;
        private System.Windows.Forms.GroupBox grbRecipe;
        private System.Windows.Forms.ColumnHeader clnType;
        private System.Windows.Forms.ColumnHeader clnTitle;
        public System.Windows.Forms.ListView lstRecipes;
        private System.Windows.Forms.Label lblAccount;
        public System.Windows.Forms.Button cmdSearch;
        public System.Windows.Forms.Button cmdLogIn;
        public System.Windows.Forms.Button cmdAddRecipe;
    }
}

