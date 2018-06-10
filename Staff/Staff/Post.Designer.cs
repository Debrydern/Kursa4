namespace Staff
{
    partial class Post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            this.AddPostBox = new System.Windows.Forms.TextBox();
            this.AddPostsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPostBox
            // 
            this.AddPostBox.Location = new System.Drawing.Point(15, 14);
            this.AddPostBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddPostBox.Name = "AddPostBox";
            this.AddPostBox.Size = new System.Drawing.Size(324, 27);
            this.AddPostBox.TabIndex = 0;
            // 
            // AddPostsBtn
            // 
            this.AddPostsBtn.Location = new System.Drawing.Point(98, 51);
            this.AddPostsBtn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddPostsBtn.Name = "AddPostsBtn";
            this.AddPostsBtn.Size = new System.Drawing.Size(138, 37);
            this.AddPostsBtn.TabIndex = 1;
            this.AddPostsBtn.Text = "Додати";
            this.AddPostsBtn.UseVisualStyleBackColor = true;
            this.AddPostsBtn.Click += new System.EventHandler(this.AddPostsBtn_Click);
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 134);
            this.Controls.Add(this.AddPostsBtn);
            this.Controls.Add(this.AddPostBox);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Post";
            this.Text = "Додавання посади";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddPostBox;
        private System.Windows.Forms.Button AddPostsBtn;
    }
}