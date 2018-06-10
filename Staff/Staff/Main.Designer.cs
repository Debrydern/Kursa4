namespace Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DepartamentBtn = new System.Windows.Forms.Button();
            this.PostsBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.FillBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DepartamentBtn);
            this.groupBox1.Controls.Add(this.PostsBtn);
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.FillBtn);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(774, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Меню";
            // 
            // DepartamentBtn
            // 
            this.DepartamentBtn.AutoEllipsis = true;
            this.DepartamentBtn.Location = new System.Drawing.Point(407, 263);
            this.DepartamentBtn.Name = "DepartamentBtn";
            this.DepartamentBtn.Size = new System.Drawing.Size(342, 151);
            this.DepartamentBtn.TabIndex = 2;
            this.DepartamentBtn.Text = "Додати відділ";
            this.DepartamentBtn.UseVisualStyleBackColor = true;
            this.DepartamentBtn.Click += new System.EventHandler(this.DepartamentBtn_Click);
            // 
            // PostsBtn
            // 
            this.PostsBtn.AutoEllipsis = true;
            this.PostsBtn.Location = new System.Drawing.Point(26, 263);
            this.PostsBtn.Name = "PostsBtn";
            this.PostsBtn.Size = new System.Drawing.Size(342, 151);
            this.PostsBtn.TabIndex = 1;
            this.PostsBtn.Text = "Додати посаду";
            this.PostsBtn.UseVisualStyleBackColor = true;
            this.PostsBtn.Click += new System.EventHandler(this.PostsBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.AutoEllipsis = true;
            this.SearchBtn.Location = new System.Drawing.Point(407, 67);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(342, 151);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Знайти анкету";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // FillBtn
            // 
            this.FillBtn.AutoEllipsis = true;
            this.FillBtn.Location = new System.Drawing.Point(26, 67);
            this.FillBtn.Name = "FillBtn";
            this.FillBtn.Size = new System.Drawing.Size(342, 151);
            this.FillBtn.TabIndex = 0;
            this.FillBtn.Text = "Створити нову анкету";
            this.FillBtn.UseVisualStyleBackColor = true;
            this.FillBtn.Click += new System.EventHandler(this.FillBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 474);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "ПО відділ кадрів";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button FillBtn;
        private System.Windows.Forms.Button DepartamentBtn;
        private System.Windows.Forms.Button PostsBtn;
    }
}

