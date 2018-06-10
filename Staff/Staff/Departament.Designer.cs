namespace Staff
{
    partial class Departament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Departament));
            this.AddNewDepartamentBox = new System.Windows.Forms.TextBox();
            this.AddDepartamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewDepartamentBox
            // 
            this.AddNewDepartamentBox.Location = new System.Drawing.Point(12, 12);
            this.AddNewDepartamentBox.Name = "AddNewDepartamentBox";
            this.AddNewDepartamentBox.Size = new System.Drawing.Size(348, 27);
            this.AddNewDepartamentBox.TabIndex = 0;
            // 
            // AddDepartamentBtn
            // 
            this.AddDepartamentBtn.Location = new System.Drawing.Point(90, 58);
            this.AddDepartamentBtn.Name = "AddDepartamentBtn";
            this.AddDepartamentBtn.Size = new System.Drawing.Size(180, 39);
            this.AddDepartamentBtn.TabIndex = 1;
            this.AddDepartamentBtn.Text = "Додати";
            this.AddDepartamentBtn.UseVisualStyleBackColor = true;
            this.AddDepartamentBtn.Click += new System.EventHandler(this.AddDepartamentBtn_Click);
            // 
            // Departament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 105);
            this.Controls.Add(this.AddDepartamentBtn);
            this.Controls.Add(this.AddNewDepartamentBox);
            this.Font = new System.Drawing.Font("Bookman Old Style", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Departament";
            this.Text = "Додавання відділу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AddNewDepartamentBox;
        private System.Windows.Forms.Button AddDepartamentBtn;
    }
}