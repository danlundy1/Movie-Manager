namespace Movie
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMovieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoviesListDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.maintenanceToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // refreshListToolStripMenuItem
            // 
            this.refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            this.refreshListToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.refreshListToolStripMenuItem.Text = "Refresh List";
            this.refreshListToolStripMenuItem.Click += new System.EventHandler(this.RefreshListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // maintenanceToolStripMenuItem
            // 
            this.maintenanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddMovieToolStripMenuItem,
            this.updateMovieToolStripMenuItem,
            this.deleteMovieToolStripMenuItem});
            this.maintenanceToolStripMenuItem.Name = "maintenanceToolStripMenuItem";
            this.maintenanceToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.maintenanceToolStripMenuItem.Text = "Maintenance";
            // 
            // AddMovieToolStripMenuItem
            // 
            this.AddMovieToolStripMenuItem.Name = "AddMovieToolStripMenuItem";
            this.AddMovieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.AddMovieToolStripMenuItem.Text = "Add Movie";
            this.AddMovieToolStripMenuItem.Click += new System.EventHandler(this.AddMovieToolStripMenuItem_Click);
            // 
            // updateMovieToolStripMenuItem
            // 
            this.updateMovieToolStripMenuItem.Name = "updateMovieToolStripMenuItem";
            this.updateMovieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.updateMovieToolStripMenuItem.Text = "Update Movie";
            this.updateMovieToolStripMenuItem.Click += new System.EventHandler(this.UpdateMovieToolStripMenuItem_Click);
            // 
            // deleteMovieToolStripMenuItem
            // 
            this.deleteMovieToolStripMenuItem.Name = "deleteMovieToolStripMenuItem";
            this.deleteMovieToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.deleteMovieToolStripMenuItem.Text = "Delete Movie";
            this.deleteMovieToolStripMenuItem.Click += new System.EventHandler(this.DeleteMovieToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MoviesListDataGridView
            // 
            this.MoviesListDataGridView.AllowUserToAddRows = false;
            this.MoviesListDataGridView.AllowUserToDeleteRows = false;
            this.MoviesListDataGridView.AllowUserToOrderColumns = true;
            this.MoviesListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoviesListDataGridView.Location = new System.Drawing.Point(33, 27);
            this.MoviesListDataGridView.Name = "MoviesListDataGridView";
            this.MoviesListDataGridView.ReadOnly = true;
            this.MoviesListDataGridView.Size = new System.Drawing.Size(794, 678);
            this.MoviesListDataGridView.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(856, 726);
            this.Controls.Add(this.MoviesListDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Movie Manager Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoviesListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMovieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataGridView MoviesListDataGridView;
    }
}

