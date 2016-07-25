namespace Retete
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.recipeButton = new System.Windows.Forms.Button();
            this.randomRecipeGroupBox = new System.Windows.Forms.GroupBox();
            this.categoriesListBox = new System.Windows.Forms.ListBox();
            this.filterTextBox = new System.Windows.Forms.TextBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.filterLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.randomRecipeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Retete.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(23, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // recipeButton
            // 
            this.recipeButton.Location = new System.Drawing.Point(48, 247);
            this.recipeButton.Name = "recipeButton";
            this.recipeButton.Size = new System.Drawing.Size(136, 36);
            this.recipeButton.TabIndex = 1;
            this.recipeButton.Text = "Cauta reteta";
            this.recipeButton.UseVisualStyleBackColor = true;
            this.recipeButton.Click += new System.EventHandler(this.recipeButton_Click);
            // 
            // randomRecipeGroupBox
            // 
            this.randomRecipeGroupBox.Controls.Add(this.filterLinkLabel);
            this.randomRecipeGroupBox.Controls.Add(this.filterLabel);
            this.randomRecipeGroupBox.Controls.Add(this.filterTextBox);
            this.randomRecipeGroupBox.Controls.Add(this.categoriesListBox);
            this.randomRecipeGroupBox.Controls.Add(this.recipeButton);
            this.randomRecipeGroupBox.Location = new System.Drawing.Point(23, 124);
            this.randomRecipeGroupBox.Name = "randomRecipeGroupBox";
            this.randomRecipeGroupBox.Size = new System.Drawing.Size(235, 289);
            this.randomRecipeGroupBox.TabIndex = 2;
            this.randomRecipeGroupBox.TabStop = false;
            this.randomRecipeGroupBox.Text = "Reteta aleatoare";
            // 
            // categoriesListBox
            // 
            this.categoriesListBox.FormattingEnabled = true;
            this.categoriesListBox.Location = new System.Drawing.Point(7, 19);
            this.categoriesListBox.Name = "categoriesListBox";
            this.categoriesListBox.Size = new System.Drawing.Size(222, 147);
            this.categoriesListBox.TabIndex = 2;
            // 
            // filterTextBox
            // 
            this.filterTextBox.Location = new System.Drawing.Point(7, 201);
            this.filterTextBox.Multiline = true;
            this.filterTextBox.Name = "filterTextBox";
            this.filterTextBox.Size = new System.Drawing.Size(222, 40);
            this.filterTextBox.TabIndex = 3;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(7, 182);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(83, 13);
            this.filterLabel.TabIndex = 4;
            this.filterLabel.Text = "Filtru de cautare";
            // 
            // filterLinkLabel
            // 
            this.filterLinkLabel.AutoSize = true;
            this.filterLinkLabel.Location = new System.Drawing.Point(96, 182);
            this.filterLinkLabel.Name = "filterLinkLabel";
            this.filterLinkLabel.Size = new System.Drawing.Size(69, 13);
            this.filterLinkLabel.TabIndex = 5;
            this.filterLinkLabel.TabStop = true;
            this.filterLinkLabel.Text = "(Cum adica?)";
            this.filterLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.filterLinkLabel_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 425);
            this.Controls.Add(this.randomRecipeGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Retete";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.randomRecipeGroupBox.ResumeLayout(false);
            this.randomRecipeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button recipeButton;
        private System.Windows.Forms.GroupBox randomRecipeGroupBox;
        private System.Windows.Forms.ListBox categoriesListBox;
        private System.Windows.Forms.TextBox filterTextBox;
        private System.Windows.Forms.LinkLabel filterLinkLabel;
        private System.Windows.Forms.Label filterLabel;
    }
}

