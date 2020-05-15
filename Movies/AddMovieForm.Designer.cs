using System;

namespace Movies
{
    partial class AddMovieForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.addMovieFormTitle = new System.Windows.Forms.TextBox();
            this.addMovieFormYear = new System.Windows.Forms.TextBox();
            this.addMovieFormDirector = new System.Windows.Forms.TextBox();
            this.addMovieFormGenre = new System.Windows.Forms.ComboBox();
            this.addMovieFormRottenTomatoesScore = new System.Windows.Forms.TextBox();
            this.addMovieFormTotalEarned = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rotten Tomatoes Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(257, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Box Office Earnings:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 31);
            this.label7.TabIndex = 6;
            this.label7.Text = "Add Movie Screen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Location = new System.Drawing.Point(18, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 51);
            this.panel1.TabIndex = 7;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(363, 8);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(85, 40);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(148, 8);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(85, 40);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(23, 8);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(85, 40);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // addMovieFormTitle
            // 
            this.addMovieFormTitle.Location = new System.Drawing.Point(83, 78);
            this.addMovieFormTitle.Name = "addMovieFormTitle";
            this.addMovieFormTitle.Size = new System.Drawing.Size(277, 20);
            this.addMovieFormTitle.TabIndex = 8;
            // 
            // addMovieFormYear
            // 
            this.addMovieFormYear.Location = new System.Drawing.Point(83, 114);
            this.addMovieFormYear.Name = "addMovieFormYear";
            this.addMovieFormYear.Size = new System.Drawing.Size(121, 20);
            this.addMovieFormYear.TabIndex = 9;
            // 
            // addMovieFormDirector
            // 
            this.addMovieFormDirector.Location = new System.Drawing.Point(83, 140);
            this.addMovieFormDirector.Name = "addMovieFormDirector";
            this.addMovieFormDirector.Size = new System.Drawing.Size(121, 20);
            this.addMovieFormDirector.TabIndex = 10;
            // 
            // addMovieFormGenre
            // 
            this.addMovieFormGenre.FormattingEnabled = true;
            this.addMovieFormGenre.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.addMovieFormGenre.Location = new System.Drawing.Point(83, 174);
            this.addMovieFormGenre.Name = "addMovieFormGenre";
            this.addMovieFormGenre.Size = new System.Drawing.Size(121, 21);
            this.addMovieFormGenre.TabIndex = 11;
            this.addMovieFormGenre.SelectedIndexChanged += new System.EventHandler(this.addMovieFormGenre_SelectedIndexChanged);
            // 
            // addMovieFormRottenTomatoesScore
            // 
            this.addMovieFormRottenTomatoesScore.Location = new System.Drawing.Point(366, 144);
            this.addMovieFormRottenTomatoesScore.Name = "addMovieFormRottenTomatoesScore";
            this.addMovieFormRottenTomatoesScore.Size = new System.Drawing.Size(100, 20);
            this.addMovieFormRottenTomatoesScore.TabIndex = 12;
            // 
            // addMovieFormTotalEarned
            // 
            this.addMovieFormTotalEarned.Location = new System.Drawing.Point(366, 177);
            this.addMovieFormTotalEarned.Name = "addMovieFormTotalEarned";
            this.addMovieFormTotalEarned.Size = new System.Drawing.Size(100, 20);
            this.addMovieFormTotalEarned.TabIndex = 13;
            // 
            // AddMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(561, 277);
            this.Controls.Add(this.addMovieFormTotalEarned);
            this.Controls.Add(this.addMovieFormRottenTomatoesScore);
            this.Controls.Add(this.addMovieFormGenre);
            this.Controls.Add(this.addMovieFormDirector);
            this.Controls.Add(this.addMovieFormYear);
            this.Controls.Add(this.addMovieFormTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AddMovieForm";
            this.Text = "Add Movie Form";
            this.Load += new System.EventHandler(this.AddMovieForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AddMovieForm_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox addMovieFormTitle;
        private System.Windows.Forms.TextBox addMovieFormYear;
        private System.Windows.Forms.TextBox addMovieFormDirector;
        private System.Windows.Forms.ComboBox addMovieFormGenre;
        private System.Windows.Forms.TextBox addMovieFormRottenTomatoesScore;
        private System.Windows.Forms.TextBox addMovieFormTotalEarned;
    }
}