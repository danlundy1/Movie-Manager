namespace Movies
{
    partial class UpdateMovieForm
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
            this.updateMovieFormTitle = new System.Windows.Forms.TextBox();
            this.updateMovieFormYear = new System.Windows.Forms.TextBox();
            this.updateMovieFormDirector = new System.Windows.Forms.TextBox();
            this.updateFormGenre = new System.Windows.Forms.ComboBox();
            this.updateMovieFormRottenTomatoesScore = new System.Windows.Forms.TextBox();
            this.updateMovieFormTotalEarned = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.FindButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Rotten Tomatoes Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Box Office Earnings:";
            // 
            // updateMovieFormTitle
            // 
            this.updateMovieFormTitle.Location = new System.Drawing.Point(83, 51);
            this.updateMovieFormTitle.Name = "updateMovieFormTitle";
            this.updateMovieFormTitle.Size = new System.Drawing.Size(277, 20);
            this.updateMovieFormTitle.TabIndex = 9;
            // 
            // updateMovieFormYear
            // 
            this.updateMovieFormYear.Location = new System.Drawing.Point(83, 88);
            this.updateMovieFormYear.Name = "updateMovieFormYear";
            this.updateMovieFormYear.Size = new System.Drawing.Size(121, 20);
            this.updateMovieFormYear.TabIndex = 10;
            // 
            // updateMovieFormDirector
            // 
            this.updateMovieFormDirector.Location = new System.Drawing.Point(83, 121);
            this.updateMovieFormDirector.Name = "updateMovieFormDirector";
            this.updateMovieFormDirector.Size = new System.Drawing.Size(121, 20);
            this.updateMovieFormDirector.TabIndex = 11;
            // 
            // updateFormGenre
            // 
            this.updateFormGenre.FormattingEnabled = true;
            this.updateFormGenre.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.updateFormGenre.Location = new System.Drawing.Point(83, 154);
            this.updateFormGenre.Name = "updateFormGenre";
            this.updateFormGenre.Size = new System.Drawing.Size(121, 21);
            this.updateFormGenre.TabIndex = 12;
            // 
            // updateMovieFormRottenTomatoesScore
            // 
            this.updateMovieFormRottenTomatoesScore.Location = new System.Drawing.Point(341, 122);
            this.updateMovieFormRottenTomatoesScore.Name = "updateMovieFormRottenTomatoesScore";
            this.updateMovieFormRottenTomatoesScore.Size = new System.Drawing.Size(100, 20);
            this.updateMovieFormRottenTomatoesScore.TabIndex = 13;
            // 
            // updateMovieFormTotalEarned
            // 
            this.updateMovieFormTotalEarned.Location = new System.Drawing.Point(341, 154);
            this.updateMovieFormTotalEarned.Name = "updateMovieFormTotalEarned";
            this.updateMovieFormTotalEarned.Size = new System.Drawing.Size(100, 20);
            this.updateMovieFormTotalEarned.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.UpdateButton);
            this.panel1.Location = new System.Drawing.Point(19, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 51);
            this.panel1.TabIndex = 15;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(322, 8);
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
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(23, 8);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(85, 40);
            this.UpdateButton.TabIndex = 0;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Update Movie Screen";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(366, 49);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 16;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // UpdateMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 262);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.updateMovieFormTotalEarned);
            this.Controls.Add(this.updateMovieFormRottenTomatoesScore);
            this.Controls.Add(this.updateFormGenre);
            this.Controls.Add(this.updateMovieFormDirector);
            this.Controls.Add(this.updateMovieFormYear);
            this.Controls.Add(this.updateMovieFormTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "UpdateMovieForm";
            this.Text = "Update Movie";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateMovieFormTitle;
        private System.Windows.Forms.TextBox updateMovieFormYear;
        private System.Windows.Forms.TextBox updateMovieFormDirector;
        private System.Windows.Forms.ComboBox updateFormGenre;
        private System.Windows.Forms.TextBox updateMovieFormRottenTomatoesScore;
        private System.Windows.Forms.TextBox updateMovieFormTotalEarned;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button FindButton;
    }
}