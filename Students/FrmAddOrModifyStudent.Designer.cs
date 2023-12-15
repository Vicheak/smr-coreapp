namespace StudentManagementAndReport.Students
{
    partial class FrmAddOrModifyStudent
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
            System.Windows.Forms.Label studentUUIDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birthDateLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.lblTitle = new System.Windows.Forms.Label();
            this.studentDbDataSet = new StudentManagementAndReport.StudentDbDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new StudentManagementAndReport.StudentDbDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new StudentManagementAndReport.StudentDbDataSetTableAdapters.TableAdapterManager();
            this.studentUUIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.telephoneTextBox = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            studentUUIDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthDateLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // studentUUIDLabel
            // 
            studentUUIDLabel.AutoSize = true;
            studentUUIDLabel.ForeColor = System.Drawing.Color.White;
            studentUUIDLabel.Location = new System.Drawing.Point(9, 76);
            studentUUIDLabel.Name = "studentUUIDLabel";
            studentUUIDLabel.Size = new System.Drawing.Size(132, 33);
            studentUUIDLabel.TabIndex = 4;
            studentUUIDLabel.Text = "អត្តលេខសិស្ស​ ៖";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.ForeColor = System.Drawing.Color.White;
            firstNameLabel.Location = new System.Drawing.Point(9, 122);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(108, 33);
            firstNameLabel.TabIndex = 6;
            firstNameLabel.Text = "នាមត្រកូល ៖";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.ForeColor = System.Drawing.Color.White;
            lastNameLabel.Location = new System.Drawing.Point(9, 168);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(84, 33);
            lastNameLabel.TabIndex = 8;
            lastNameLabel.Text = "នាមខ្លួន ៖";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.ForeColor = System.Drawing.Color.White;
            genderLabel.Location = new System.Drawing.Point(9, 214);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(60, 33);
            genderLabel.TabIndex = 10;
            genderLabel.Text = "ភេទ ៖";
            // 
            // birthDateLabel
            // 
            birthDateLabel.AutoSize = true;
            birthDateLabel.ForeColor = System.Drawing.Color.White;
            birthDateLabel.Location = new System.Drawing.Point(9, 261);
            birthDateLabel.Name = "birthDateLabel";
            birthDateLabel.Size = new System.Drawing.Size(138, 33);
            birthDateLabel.TabIndex = 12;
            birthDateLabel.Text = "ថ្ងៃខែឆ្នាំកំណើត ៖";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.ForeColor = System.Drawing.Color.White;
            addressLabel.Location = new System.Drawing.Point(9, 306);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(114, 33);
            addressLabel.TabIndex = 14;
            addressLabel.Text = "អាស័យដ្ឋាន ៖";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.ForeColor = System.Drawing.Color.White;
            telephoneLabel.Location = new System.Drawing.Point(9, 439);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(177, 33);
            telephoneLabel.TabIndex = 16;
            telephoneLabel.Text = "ល.ទូ.អាណាព្យាបាល ៖";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(12, 339);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 24);
            label1.TabIndex = 21;
            label1.Text = "ភូមិ... ឃុំ... ស្រុក...​ ខេត្ត...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(12, 415);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(87, 24);
            label2.TabIndex = 22;
            label2.Text = "+855xxxxxxxx";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Khmer M1", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Image = global::StudentManagementAndReport.Properties.Resources.icons8_add_user_male_30px_1;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(532, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "បន្ថែមសិស្សនៅថ្នាក់​ ?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentDbDataSet
            // 
            this.studentDbDataSet.DataSetName = "StudentDbDataSet";
            this.studentDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentDbDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassTableAdapter = null;
            this.tableAdapterManager.MonthsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.StudentsTableAdapter = this.studentsTableAdapter;
            this.tableAdapterManager.StudyYearsTableAdapter = null;
            this.tableAdapterManager.TeacherClassTableAdapter = null;
            this.tableAdapterManager.TeachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = StudentManagementAndReport.StudentDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            this.tableAdapterManager.ValuationsTableAdapter = null;
            // 
            // studentUUIDTextBox
            // 
            this.studentUUIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "StudentUUID", true));
            this.studentUUIDTextBox.Location = new System.Drawing.Point(194, 69);
            this.studentUUIDTextBox.Name = "studentUUIDTextBox";
            this.studentUUIDTextBox.Size = new System.Drawing.Size(263, 40);
            this.studentUUIDTextBox.TabIndex = 0;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(194, 115);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(323, 40);
            this.firstNameTextBox.TabIndex = 1;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(194, 161);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(323, 40);
            this.lastNameTextBox.TabIndex = 2;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.Red;
            this.birthDateDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.birthDateDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.birthDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.studentsBindingSource, "BirthDate", true));
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(194, 254);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(203, 40);
            this.birthDateDateTimePicker.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(194, 306);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(323, 113);
            this.addressTextBox.TabIndex = 5;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.studentsBindingSource, "Telephone", true));
            this.telephoneTextBox.Location = new System.Drawing.Point(194, 432);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(323, 40);
            this.telephoneTextBox.TabIndex = 6;
            // 
            // cbGender
            // 
            this.cbGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGender.DisplayMember = "ClassName";
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "ប្រុស",
            "ស្រី"});
            this.cbGender.Location = new System.Drawing.Point(194, 206);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(203, 41);
            this.cbGender.TabIndex = 3;
            this.cbGender.ValueMember = "ClassID";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = global::StudentManagementAndReport.Properties.Resources.icons8_undo_30px_2;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(243, 502);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCancel.Size = new System.Drawing.Size(126, 41);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "   ត្រលប់";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::StudentManagementAndReport.Properties.Resources.icon8_save_26px;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(391, 502);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSave.Size = new System.Drawing.Size(126, 41);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "    រក្សាទុក";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Yellow;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(15, 502);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 41);
            this.btnClear.TabIndex = 20;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "សម្អាត";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmAddOrModifyStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::StudentManagementAndReport.Properties.Resources.icons8_add_user_male_200px;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(532, 571);
            this.ControlBox = false;
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(studentUUIDLabel);
            this.Controls.Add(this.studentUUIDTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(genderLabel);
            this.Controls.Add(birthDateLabel);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAddOrModifyStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddOrModifyStudent";
            this.Load += new System.EventHandler(this.FrmAddOrModifyStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentDbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private StudentDbDataSet studentDbDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentDbDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private StudentDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox studentUUIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}