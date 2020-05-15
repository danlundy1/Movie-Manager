namespace Movies
{
    partial class DeleteMovieForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteMovieFormTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.deleteMovieFormYear = new System.Windows.Forms.TextBox();
            this.deleteMovieFormDirector = new System.Windows.Forms.TextBox();
            this.deleteMovieFormGenre = new System.Windows.Forms.ComboBox();
            this.deleteMovieFormRottenTomatoesScore = new System.Windows.Forms.TextBox();
            this.deleteMovieFormTotalEarned = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeleteFormFindButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(284, 31);
            this.label7.TabIndex = 7;
            this.label7.Text = "Delete Movie Screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Movie Title:";
            // 
            // deleteMovieFormTitle
            // 
            this.deleteMovieFormTitle.Location = new System.Drawing.Point(85, 66);
            this.deleteMovieFormTitle.Name = "deleteMovieFormTitle";
            this.deleteMovieFormTitle.Size = new System.Drawing.Size(277, 20);
            this.deleteMovieFormTitle.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rotten Tomatoes Score:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Box Office Earnings:";
            // 
            // deleteMovieFormYear
            // 
            this.deleteMovieFormYear.Location = new System.Drawing.Point(85, 108);
            this.deleteMovieFormYear.Name = "deleteMovieFormYear";
            this.deleteMovieFormYear.Size = new System.Drawing.Size(121, 20);
            this.deleteMovieFormYear.TabIndex = 15;
            // 
            // deleteMovieFormDirector
            // 
            this.deleteMovieFormDirector.Location = new System.Drawing.Point(85, 143);
            this.deleteMovieFormDirector.Name = "deleteMovieFormDirector";
            this.deleteMovieFormDirector.Size = new System.Drawing.Size(121, 20);
            this.deleteMovieFormDirector.TabIndex = 16;
            // 
            // deleteMovieFormGenre
            // 
            this.deleteMovieFormGenre.FormattingEnabled = true;
            this.deleteMovieFormGenre.Items.AddRange(new object[] {
            "Animation",
            "Action",
            "Comedy",
            "Drama",
            "Horror",
            "Mystery",
            "Romance",
            "Science Fiction",
            "Western"});
            this.deleteMovieFormGenre.Location = new System.Drawing.Point(85, 178);
            this.deleteMovieFormGenre.Name = "deleteMovieFormGenre";
            this.deleteMovieFormGenre.Size = new System.Drawing.Size(121, 21);
            this.deleteMovieFormGenre.TabIndex = 17;
            this.deleteMovieFormGenre.SelectedIndexChanged += new System.EventHandler(this.deleteMovieFormGenre_SelectedIndexChanged);
            // 
            // deleteMovieFormRottenTomatoesScore
            // 
            this.deleteMovieFormRottenTomatoesScore.Location = new System.Drawing.Point(343, 143);
            this.deleteMovieFormRottenTomatoesScore.Name = "deleteMovieFormRottenTomatoesScore";
            this.deleteMovieFormRottenTomatoesScore.Size = new System.Drawing.Size(100, 20);
            this.deleteMovieFormRottenTomatoesScore.TabIndex = 18;
            // 
            // deleteMovieFormTotalEarned
            // 
            this.deleteMovieFormTotalEarned.Location = new System.Drawing.Point(343, 178);
            this.deleteMovieFormTotalEarned.Name = "deleteMovieFormTotalEarned";
            this.deleteMovieFormTotalEarned.Size = new System.Drawing.Size(100, 20);
            this.deleteMovieFormTotalEarned.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Location = new System.Drawing.Point(33, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 51);
            this.panel1.TabIndex = 20;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(326, 8);
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
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(23, 8);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(85, 40);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeleteFormFindButton
            // 
            this.DeleteFormFindButton.Location = new System.Drawing.Point(368, 64);
            this.DeleteFormFindButton.Name = "DeleteFormFindButton";
            this.DeleteFormFindButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteFormFindButton.TabIndex = 21;
            this.DeleteFormFindButton.Text = "Find";
            this.DeleteFormFindButton.UseVisualStyleBackColor = true;
            this.DeleteFormFindButton.Click += new System.EventHandler(this.DeleteFormFindButton_Click);
            // 
            // DeleteMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 301);
            this.Controls.Add(this.DeleteFormFindButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteMovieFormTotalEarned);
            this.Controls.Add(this.deleteMovieFormRottenTomatoesScore);
            this.Controls.Add(this.deleteMovieFormGenre);
            this.Controls.Add(this.deleteMovieFormDirector);
            this.Controls.Add(this.deleteMovieFormYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleteMovieFormTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DeleteMovieForm";
            this.Text = "Delete Movie";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deleteMovieFormTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox deleteMovieFormYear;
        private System.Windows.Forms.TextBox deleteMovieFormDirector;
        private System.Windows.Forms.ComboBox deleteMovieFormGenre;
        private System.Windows.Forms.TextBox deleteMovieFormRottenTomatoesScore;
        private System.Windows.Forms.TextBox deleteMovieFormTotalEarned;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button DeleteFormFindButton;
    }
}