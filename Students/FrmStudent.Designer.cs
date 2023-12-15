namespace StudentManagementAndReport.Students
{
    partial class FrmStudent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvShowStudent = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentUUIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.classIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentDbDataSet = new StudentManagementAndReport.StudentDbDataSet();
            this.studentsTableAdapter = new StudentManagementAndReport.StudentDbDataSetTableAdapters.StudentsTableAdapter();
            this.tableAdapterManager = new StudentManagementAndReport.StudentDbDataSetTableAdapters.TableAdapterManager();
            this.toolStripStudentInfo = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalStudent = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalMale = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLblTotalFemale = new System.Windows.Forms.ToolStripLabel();
            this.btnReload = new System.Windows.Forms.Button();
            this.cbChooseClass = new System.Windows.Forms.ComboBox();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.classTableAdapter = new StudentManagementAndReport.StudentDbDataSetTableAdapters.ClassTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbChooseGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbChooseTelephone = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDbDataSet)).BeginInit();
            this.toolStripStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Khmer M1", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::StudentManagementAndReport.Properties.Resources.icons8_management_30px;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1182, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "         បញ្ជីរាយឈ្មោះសិស្សតាមថ្នាក់";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvShowStudent
            // 
            this.dgvShowStudent.AllowUserToAddRows = false;
            this.dgvShowStudent.AllowUserToDeleteRows = false;
            this.dgvShowStudent.AllowUserToResizeColumns = false;
            this.dgvShowStudent.AllowUserToResizeRows = false;
            this.dgvShowStudent.AutoGenerateColumns = false;
            this.dgvShowStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvShowStudent.ColumnHeadersHeight = 40;
            this.dgvShowStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShowStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentUUIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.isActiveDataGridViewCheckBoxColumn,
            this.classIDDataGridViewTextBoxColumn,
            this.ColumnEdit,
            this.ColumnDelete});
            this.dgvShowStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvShowStudent.DataSource = this.studentsBindingSource;
            this.dgvShowStudent.EnableHeadersVisualStyles = false;
            this.dgvShowStudent.Location = new System.Drawing.Point(12, 197);
            this.dgvShowStudent.Name = "dgvShowStudent";
            this.dgvShowStudent.ReadOnly = true;
            this.dgvShowStudent.RowHeadersWidth = 51;
            this.dgvShowStudent.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvShowStudent.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowStudent.RowTemplate.Height = 35;
            this.dgvShowStudent.Size = new System.Drawing.Size(1158, 514);
            this.dgvShowStudent.TabIndex = 1;
            this.dgvShowStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowStudent_CellContentClick);
            this.dgvShowStudent.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvShowStudent_Paint);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "StudentID";
            this.studentIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentIDDataGridViewTextBoxColumn.Visible = false;
            this.studentIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentUUIDDataGridViewTextBoxColumn
            // 
            this.studentUUIDDataGridViewTextBoxColumn.DataPropertyName = "StudentUUID";
            this.studentUUIDDataGridViewTextBoxColumn.HeaderText = "អត្តលេខសិស្ស";
            this.studentUUIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentUUIDDataGridViewTextBoxColumn.Name = "studentUUIDDataGridViewTextBoxColumn";
            this.studentUUIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentUUIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "នាមត្រកូល";
            this.firstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "នាមខ្លួន";
            this.lastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Red;
            this.genderDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.genderDataGridViewTextBoxColumn.HeaderText = "ភេទ";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "ថ្ងៃខែឆ្នាំកំណើត";
            this.birthDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            this.birthDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "អាស័យដ្ឋាន";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            this.addressDataGridViewTextBoxColumn.Visible = false;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "លេខទូរស័ព្ទអាណាព្យាបាល";
            this.telephoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            this.isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            this.isActiveDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            this.isActiveDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewCheckBoxColumn.Visible = false;
            this.isActiveDataGridViewCheckBoxColumn.Width = 125;
            // 
            // classIDDataGridViewTextBoxColumn
            // 
            this.classIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID";
            this.classIDDataGridViewTextBoxColumn.HeaderText = "ClassID";
            this.classIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.classIDDataGridViewTextBoxColumn.Name = "classIDDataGridViewTextBoxColumn";
            this.classIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.classIDDataGridViewTextBoxColumn.Visible = false;
            this.classIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ColumnEdit
            // 
            this.ColumnEdit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnEdit.HeaderText = "កែប្រែ";
            this.ColumnEdit.Image = global::StudentManagementAndReport.Properties.Resources.icons8_edit_16px_1;
            this.ColumnEdit.MinimumWidth = 51;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.ReadOnly = true;
            this.ColumnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEdit.Width = 86;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnDelete.HeaderText = "លុប";
            this.ColumnDelete.Image = global::StudentManagementAndReport.Properties.Resources.icons8_trash_can_16px;
            this.ColumnDelete.MinimumWidth = 6;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            this.ColumnDelete.Width = 51;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.studentDbDataSet;
            // 
            // studentDbDataSet
            // 
            this.studentDbDataSet.DataSetName = "StudentDbDataSet";
            this.studentDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // toolStripStudentInfo
            // 
            this.toolStripStudentInfo.BackColor = System.Drawing.Color.White;
            this.toolStripStudentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripStudentInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripStudentInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLblTotalStudent,
            this.toolStripLabel2,
            this.toolStripLblTotalMale,
            this.toolStripLabel3,
            this.toolStripLblTotalFemale});
            this.toolStripStudentInfo.Location = new System.Drawing.Point(0, 726);
            this.toolStripStudentInfo.Name = "toolStripStudentInfo";
            this.toolStripStudentInfo.Size = new System.Drawing.Size(1182, 27);
            this.toolStripStudentInfo.TabIndex = 2;
            this.toolStripStudentInfo.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(104, 24);
            this.toolStripLabel1.Text = "ចំនួនសិស្សសរុប ៖";
            // 
            // toolStripLblTotalStudent
            // 
            this.toolStripLblTotalStudent.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLblTotalStudent.ForeColor = System.Drawing.Color.Red;
            this.toolStripLblTotalStudent.Name = "toolStripLblTotalStudent";
            this.toolStripLblTotalStudent.Size = new System.Drawing.Size(20, 24);
            this.toolStripLblTotalStudent.Text = "?";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(73, 24);
            this.toolStripLabel2.Text = "ប្រុសសរុប ៖";
            // 
            // toolStripLblTotalMale
            // 
            this.toolStripLblTotalMale.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLblTotalMale.ForeColor = System.Drawing.Color.Red;
            this.toolStripLblTotalMale.Name = "toolStripLblTotalMale";
            this.toolStripLblTotalMale.Size = new System.Drawing.Size(20, 24);
            this.toolStripLblTotalMale.Text = "?";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(64, 24);
            this.toolStripLabel3.Text = "ស្រីសរុប ៖";
            // 
            // toolStripLblTotalFemale
            // 
            this.toolStripLblTotalFemale.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLblTotalFemale.ForeColor = System.Drawing.Color.Red;
            this.toolStripLblTotalFemale.Name = "toolStripLblTotalFemale";
            this.toolStripLblTotalFemale.Size = new System.Drawing.Size(20, 24);
            this.toolStripLblTotalFemale.Text = "?";
            // 
            // btnReload
            // 
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.Image = global::StudentManagementAndReport.Properties.Resources.icons8_refresh_30px;
            this.btnReload.Location = new System.Drawing.Point(12, 57);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(40, 40);
            this.btnReload.TabIndex = 3;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // cbChooseClass
            // 
            this.cbChooseClass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbChooseClass.DataSource = this.classBindingSource;
            this.cbChooseClass.DisplayMember = "ClassName";
            this.cbChooseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseClass.FormattingEnabled = true;
            this.cbChooseClass.Location = new System.Drawing.Point(306, 56);
            this.cbChooseClass.Name = "cbChooseClass";
            this.cbChooseClass.Size = new System.Drawing.Size(233, 41);
            this.cbChooseClass.TabIndex = 4;
            this.cbChooseClass.ValueMember = "ClassID";
            this.cbChooseClass.SelectedIndexChanged += new System.EventHandler(this.cbChooseClass_SelectedIndexChanged);
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.studentDbDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "ជ្រើសរើសថ្នាក់រៀន​ ៖";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNew.Image = global::StudentManagementAndReport.Properties.Resources.icons8_add_user_male_30px_1;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(1056, 56);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAddNew.Size = new System.Drawing.Size(114, 41);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "បន្ថែមថ្មី";
            this.btnAddNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(796, 104);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(254, 40);
            this.txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = global::StudentManagementAndReport.Properties.Resources.icons8_search_30px;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1056, 103);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(114, 41);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "ស្វែងរក";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(961, 729);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "រក្សាសិទ្ធគ្រប់យ៉ាងក្នុងការប្រើប្រាស់ប្រព័ន្ធ";
            // 
            // cbChooseGender
            // 
            this.cbChooseGender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbChooseGender.DisplayMember = "ClassName";
            this.cbChooseGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseGender.FormattingEnabled = true;
            this.cbChooseGender.Items.AddRange(new object[] {
            "ទាំងអស់",
            "ប្រុស",
            "ស្រី"});
            this.cbChooseGender.Location = new System.Drawing.Point(306, 103);
            this.cbChooseGender.Name = "cbChooseGender";
            this.cbChooseGender.Size = new System.Drawing.Size(233, 41);
            this.cbChooseGender.TabIndex = 4;
            this.cbChooseGender.ValueMember = "ClassID";
            this.cbChooseGender.SelectedIndexChanged += new System.EventHandler(this.cbChooseClass_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 33);
            this.label4.TabIndex = 5;
            this.label4.Text = "បង្ហាញតាមភេទ ៖";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Khmer OS Siemreap", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(564, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 101);
            this.label5.TabIndex = 10;
            this.label5.Text = "គោលការណ៏ស្វែករកព័ត៌មានសិស្ស ៖\r\n១. វាយបញ្ខូលអត្តលេខសិស្ស\r\n២.​​​ វាយបញ្ចូលនាមត្រកូល" +
    "ឫនាមខ្លួន\r\n៣.​ ​វាយបញ្ចូលលេខទូរស័ព្ទអាណាព្យាបាល";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::StudentManagementAndReport.Properties.Resources.icons8_print_24px_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1056, 150);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(114, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "បោះពុម្ព";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cbChooseTelephone
            // 
            this.cbChooseTelephone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbChooseTelephone.DisplayMember = "ClassName";
            this.cbChooseTelephone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbChooseTelephone.FormattingEnabled = true;
            this.cbChooseTelephone.Items.AddRange(new object[] {
            "ទាំងអស់",
            "ប្រុស",
            "ស្រី"});
            this.cbChooseTelephone.Location = new System.Drawing.Point(306, 150);
            this.cbChooseTelephone.Name = "cbChooseTelephone";
            this.cbChooseTelephone.Size = new System.Drawing.Size(233, 41);
            this.cbChooseTelephone.TabIndex = 11;
            this.cbChooseTelephone.ValueMember = "ClassID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(67, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 33);
            this.label6.TabIndex = 12;
            this.label6.Text = "បង្ហាញតាមប្រព័ន្ធលេខទូរស័ព្ទ ៖";
            // 
            // FrmStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbChooseTelephone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChooseGender);
            this.Controls.Add(this.cbChooseClass);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.toolStripStudentInfo);
            this.Controls.Add(this.dgvShowStudent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Khmer OS Siemreap", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStudent";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDbDataSet)).EndInit();
            this.toolStripStudentInfo.ResumeLayout(false);
            this.toolStripStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvShowStudent;
        private StudentDbDataSet studentDbDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private StudentDbDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private StudentDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip toolStripStudentInfo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalStudent;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cbChooseClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.BindingSource classBindingSource;
        private StudentDbDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentUUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewImageColumn ColumnDelete;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalMale;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotalFemale;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbChooseGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbChooseTelephone;
        private System.Windows.Forms.Label label6;
    }
}