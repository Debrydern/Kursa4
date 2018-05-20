namespace Server
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label patronic_nameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label departmentLabel;
            System.Windows.Forms.Label postLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label nationalityLabel;
            System.Windows.Forms.Label citizenshipLabel;
            System.Windows.Forms.Label educationLabel;
            System.Windows.Forms.Label family_StatusLabel;
            System.Windows.Forms.Label vATINLabel;
            System.Windows.Forms.Label joinedLabel;
            System.Windows.Forms.Label goneLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.idTextBox1 = new System.Windows.Forms.TextBox();
            this.staff_FullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Server.DatabaseDataSet();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nationalityTextBox = new System.Windows.Forms.TextBox();
            this.citizenshipTextBox = new System.Windows.Forms.TextBox();
            this.educationTextBox = new System.Windows.Forms.TextBox();
            this.family_StatusTextBox = new System.Windows.Forms.TextBox();
            this.vATINTextBox = new System.Windows.Forms.TextBox();
            this.joinedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.goneDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.staff_ShortBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.patronic_nameTextBox = new System.Windows.Forms.TextBox();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.fotoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.staff_FullTableAdapter = new Server.DatabaseDataSetTableAdapters.Staff_FullTableAdapter();
            this.tableAdapterManager = new Server.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.staff_ShortTableAdapter = new Server.DatabaseDataSetTableAdapters.Staff_ShortTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            patronic_nameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            departmentLabel = new System.Windows.Forms.Label();
            postLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            nationalityLabel = new System.Windows.Forms.Label();
            citizenshipLabel = new System.Windows.Forms.Label();
            educationLabel = new System.Windows.Forms.Label();
            family_StatusLabel = new System.Windows.Forms.Label();
            vATINLabel = new System.Windows.Forms.Label();
            joinedLabel = new System.Windows.Forms.Label();
            goneLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staff_FullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_ShortBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(34, 61);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(34, 87);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(59, 13);
            last_nameLabel.TabIndex = 2;
            last_nameLabel.Text = "Last name:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(34, 113);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(58, 13);
            first_nameLabel.TabIndex = 4;
            first_nameLabel.Text = "First name:";
            // 
            // patronic_nameLabel
            // 
            patronic_nameLabel.AutoSize = true;
            patronic_nameLabel.Location = new System.Drawing.Point(34, 139);
            patronic_nameLabel.Name = "patronic_nameLabel";
            patronic_nameLabel.Size = new System.Drawing.Size(78, 13);
            patronic_nameLabel.TabIndex = 6;
            patronic_nameLabel.Text = "Patronic name:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(34, 166);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 8;
            birthdayLabel.Text = "Birthday:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(34, 191);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 10;
            ageLabel.Text = "Age:";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new System.Drawing.Point(34, 217);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new System.Drawing.Size(65, 13);
            departmentLabel.TabIndex = 12;
            departmentLabel.Text = "Department:";
            // 
            // postLabel
            // 
            postLabel.AutoSize = true;
            postLabel.Location = new System.Drawing.Point(34, 243);
            postLabel.Name = "postLabel";
            postLabel.Size = new System.Drawing.Size(31, 13);
            postLabel.TabIndex = 14;
            postLabel.Text = "Post:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(34, 269);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 16;
            fotoLabel.Text = "Foto:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(425, 61);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(19, 13);
            idLabel1.TabIndex = 18;
            idLabel1.Text = "Id:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(425, 87);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(28, 13);
            sexLabel.TabIndex = 20;
            sexLabel.Text = "Sex:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(425, 113);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(48, 13);
            addressLabel.TabIndex = 22;
            addressLabel.Text = "Address:";
            // 
            // nationalityLabel
            // 
            nationalityLabel.AutoSize = true;
            nationalityLabel.Location = new System.Drawing.Point(425, 139);
            nationalityLabel.Name = "nationalityLabel";
            nationalityLabel.Size = new System.Drawing.Size(59, 13);
            nationalityLabel.TabIndex = 24;
            nationalityLabel.Text = "Nationality:";
            // 
            // citizenshipLabel
            // 
            citizenshipLabel.AutoSize = true;
            citizenshipLabel.Location = new System.Drawing.Point(425, 165);
            citizenshipLabel.Name = "citizenshipLabel";
            citizenshipLabel.Size = new System.Drawing.Size(60, 13);
            citizenshipLabel.TabIndex = 26;
            citizenshipLabel.Text = "Citizenship:";
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Location = new System.Drawing.Point(425, 191);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new System.Drawing.Size(58, 13);
            educationLabel.TabIndex = 28;
            educationLabel.Text = "Education:";
            // 
            // family_StatusLabel
            // 
            family_StatusLabel.AutoSize = true;
            family_StatusLabel.Location = new System.Drawing.Point(425, 217);
            family_StatusLabel.Name = "family_StatusLabel";
            family_StatusLabel.Size = new System.Drawing.Size(72, 13);
            family_StatusLabel.TabIndex = 30;
            family_StatusLabel.Text = "Family Status:";
            // 
            // vATINLabel
            // 
            vATINLabel.AutoSize = true;
            vATINLabel.Location = new System.Drawing.Point(425, 243);
            vATINLabel.Name = "vATINLabel";
            vATINLabel.Size = new System.Drawing.Size(42, 13);
            vATINLabel.TabIndex = 32;
            vATINLabel.Text = "VATIN:";
            // 
            // joinedLabel
            // 
            joinedLabel.AutoSize = true;
            joinedLabel.Location = new System.Drawing.Point(425, 270);
            joinedLabel.Name = "joinedLabel";
            joinedLabel.Size = new System.Drawing.Size(41, 13);
            joinedLabel.TabIndex = 34;
            joinedLabel.Text = "Joined:";
            // 
            // goneLabel
            // 
            goneLabel.AutoSize = true;
            goneLabel.Location = new System.Drawing.Point(425, 296);
            goneLabel.Name = "goneLabel";
            goneLabel.Size = new System.Drawing.Size(36, 13);
            goneLabel.TabIndex = 36;
            goneLabel.Text = "Gone:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(idLabel1);
            this.tabPage1.Controls.Add(this.idTextBox1);
            this.tabPage1.Controls.Add(sexLabel);
            this.tabPage1.Controls.Add(this.sexTextBox);
            this.tabPage1.Controls.Add(addressLabel);
            this.tabPage1.Controls.Add(this.addressTextBox);
            this.tabPage1.Controls.Add(nationalityLabel);
            this.tabPage1.Controls.Add(this.nationalityTextBox);
            this.tabPage1.Controls.Add(citizenshipLabel);
            this.tabPage1.Controls.Add(this.citizenshipTextBox);
            this.tabPage1.Controls.Add(educationLabel);
            this.tabPage1.Controls.Add(this.educationTextBox);
            this.tabPage1.Controls.Add(family_StatusLabel);
            this.tabPage1.Controls.Add(this.family_StatusTextBox);
            this.tabPage1.Controls.Add(vATINLabel);
            this.tabPage1.Controls.Add(this.vATINTextBox);
            this.tabPage1.Controls.Add(joinedLabel);
            this.tabPage1.Controls.Add(this.joinedDateTimePicker);
            this.tabPage1.Controls.Add(goneLabel);
            this.tabPage1.Controls.Add(this.goneDateTimePicker);
            this.tabPage1.Controls.Add(idLabel);
            this.tabPage1.Controls.Add(this.idTextBox);
            this.tabPage1.Controls.Add(last_nameLabel);
            this.tabPage1.Controls.Add(this.last_nameTextBox);
            this.tabPage1.Controls.Add(first_nameLabel);
            this.tabPage1.Controls.Add(this.first_nameTextBox);
            this.tabPage1.Controls.Add(patronic_nameLabel);
            this.tabPage1.Controls.Add(this.patronic_nameTextBox);
            this.tabPage1.Controls.Add(birthdayLabel);
            this.tabPage1.Controls.Add(this.birthdayDateTimePicker);
            this.tabPage1.Controls.Add(ageLabel);
            this.tabPage1.Controls.Add(this.ageTextBox);
            this.tabPage1.Controls.Add(departmentLabel);
            this.tabPage1.Controls.Add(this.departmentTextBox);
            this.tabPage1.Controls.Add(postLabel);
            this.tabPage1.Controls.Add(this.postTextBox);
            this.tabPage1.Controls.Add(fotoLabel);
            this.tabPage1.Controls.Add(this.fotoTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // idTextBox1
            // 
            this.idTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_FullBindingSource, "Id", true));
            this.idTextBox1.Location = new System.Drawing.Point(503, 58);
            this.idTextBox1.Name = "idTextBox1";
            this.idTextBox1.Size = new System.Drawing.Size(200, 20);
            this.idTextBox1.TabIndex = 19;
            // 
            // staff_FullBindingSource
            // 
            this.staff_FullBindingSource.DataMember = "Staff_Full";
            this.staff_FullBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sexTextBox
            // 
            this.sexTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_FullBindingSource, "Sex", true));
            this.sexTextBox.Location = new System.Drawing.Point(503, 84);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(200, 20);
            this.sexTextBox.TabIndex = 21;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_FullBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(503, 110);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 23;
            // 
            // nationalityTextBox
            // 
            this.nationalityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_FullBindingSource, "Nationality", true));
            this.nationalityTextBox.Location = new System.Drawing.Point(503, 136);
            this.nationalityTextBox.Name = "nationalityTextBox";
            this.nationalityTextBox.Size = new System.Drawing.Size(200, 20);
            this.nationalityTextBox.TabIndex = 25;
            // 
            // citizenshipTextBox
            // 
            this.citizenshipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_FullBindingSource, "Citizenship", true));
            this.citizenshipTextBox.Location = new System.Drawing.Point(503, 162);
            this.citizenshipTextBox.Name = "citizenshipTextBox";
            this.citizenshipTextBox.Size = new System.Drawing.Size(200, 20);
            this.citizenshipTextBox.TabIndex = 27;
            // 
            // educationTextBox
            // 
            this.educationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_FullBindingSource, "Education", true));
            this.educationTextBox.Location = new System.Drawing.Point(503, 188);
            this.educationTextBox.Name = "educationTextBox";
            this.educationTextBox.Size = new System.Drawing.Size(200, 20);
            this.educationTextBox.TabIndex = 29;
            // 
            // family_StatusTextBox
            // 
            this.family_StatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_FullBindingSource, "Family_Status", true));
            this.family_StatusTextBox.Location = new System.Drawing.Point(503, 214);
            this.family_StatusTextBox.Name = "family_StatusTextBox";
            this.family_StatusTextBox.Size = new System.Drawing.Size(200, 20);
            this.family_StatusTextBox.TabIndex = 31;
            // 
            // vATINTextBox
            // 
            this.vATINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_FullBindingSource, "VATIN", true));
            this.vATINTextBox.Location = new System.Drawing.Point(503, 240);
            this.vATINTextBox.Name = "vATINTextBox";
            this.vATINTextBox.Size = new System.Drawing.Size(200, 20);
            this.vATINTextBox.TabIndex = 33;
            // 
            // joinedDateTimePicker
            // 
            this.joinedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.staff_FullBindingSource, "Joined", true));
            this.joinedDateTimePicker.Location = new System.Drawing.Point(503, 266);
            this.joinedDateTimePicker.Name = "joinedDateTimePicker";
            this.joinedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.joinedDateTimePicker.TabIndex = 35;
            // 
            // goneDateTimePicker
            // 
            this.goneDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.staff_FullBindingSource, "Gone", true));
            this.goneDateTimePicker.Location = new System.Drawing.Point(503, 292);
            this.goneDateTimePicker.Name = "goneDateTimePicker";
            this.goneDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.goneDateTimePicker.TabIndex = 37;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_ShortBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(118, 58);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // staff_ShortBindingSource
            // 
            this.staff_ShortBindingSource.DataMember = "Staff_Short";
            this.staff_ShortBindingSource.DataSource = this.databaseDataSet;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_ShortBindingSource, "Last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(118, 84);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.last_nameTextBox.TabIndex = 3;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_ShortBindingSource, "First_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(118, 110);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.first_nameTextBox.TabIndex = 5;
            // 
            // patronic_nameTextBox
            // 
            this.patronic_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_ShortBindingSource, "Patronic_name", true));
            this.patronic_nameTextBox.Location = new System.Drawing.Point(118, 136);
            this.patronic_nameTextBox.Name = "patronic_nameTextBox";
            this.patronic_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.patronic_nameTextBox.TabIndex = 7;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.staff_ShortBindingSource, "Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(118, 162);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 9;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_ShortBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(118, 188);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(200, 20);
            this.ageTextBox.TabIndex = 11;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_ShortBindingSource, "Department", true));
            this.departmentTextBox.Location = new System.Drawing.Point(118, 214);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(200, 20);
            this.departmentTextBox.TabIndex = 13;
            // 
            // postTextBox
            // 
            this.postTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_ShortBindingSource, "Post", true));
            this.postTextBox.Location = new System.Drawing.Point(118, 240);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(200, 20);
            this.postTextBox.TabIndex = 15;
            // 
            // fotoTextBox
            // 
            this.fotoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staff_ShortBindingSource, "Foto", true));
            this.fotoTextBox.Location = new System.Drawing.Point(118, 266);
            this.fotoTextBox.Name = "fotoTextBox";
            this.fotoTextBox.Size = new System.Drawing.Size(200, 20);
            this.fotoTextBox.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // staff_FullTableAdapter
            // 
            this.staff_FullTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Staff_FullTableAdapter = this.staff_FullTableAdapter;
            this.tableAdapterManager.Staff_ShortTableAdapter = this.staff_ShortTableAdapter;
            this.tableAdapterManager.UpdateOrder = Server.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staff_ShortTableAdapter
            // 
            this.staff_ShortTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staff_FullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staff_ShortBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource staff_FullBindingSource;
        private DatabaseDataSetTableAdapters.Staff_FullTableAdapter staff_FullTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.Staff_ShortTableAdapter staff_ShortTableAdapter;
        private System.Windows.Forms.BindingSource staff_ShortBindingSource;
        private System.Windows.Forms.TextBox idTextBox1;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nationalityTextBox;
        private System.Windows.Forms.TextBox citizenshipTextBox;
        private System.Windows.Forms.TextBox educationTextBox;
        private System.Windows.Forms.TextBox family_StatusTextBox;
        private System.Windows.Forms.TextBox vATINTextBox;
        private System.Windows.Forms.DateTimePicker joinedDateTimePicker;
        private System.Windows.Forms.DateTimePicker goneDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox patronic_nameTextBox;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.TextBox fotoTextBox;
    }
}

