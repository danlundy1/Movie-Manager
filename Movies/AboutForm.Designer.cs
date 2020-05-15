namespace Movies
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.aboutFormCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(563, 287);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // aboutFormCloseButton
            // 
            this.aboutFormCloseButton.Location = new System.Drawing.Point(243, 305);
            this.aboutFormCloseButton.Name = "aboutFormCloseButton";
            this.aboutFormCloseButton.Size = new System.Drawing.Size(105, 33);
            this.aboutFormCloseButton.TabIndex = 1;
            this.aboutFormCloseButton.Text = "Close";
            this.aboutFormCloseButton.UseVisualStyleBackColor = true;
            this.aboutFormCloseButton.Click += new System.EventHandler(this.aboutFormCloseButton_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.aboutFormCloseButton);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AboutForm";
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button aboutFormCloseButton;
    }
}