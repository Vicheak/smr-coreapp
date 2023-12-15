using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementAndReport.Utility; 

namespace StudentManagementAndReport.Students
{
    public partial class FrmAddOrModifyStudent : Form
    {
        public bool IsAdded { get; set; }

        public StudentDbDataSet.ClassRow ClassRow { get; set; }

        public StudentDbDataSet.StudentsRow StudentsRow { get; set; }

        public FrmAddOrModifyStudent()
        {
            InitializeComponent();
        }

        private void FrmAddOrModifyStudent_Load(object sender, EventArgs e)
        {
            if (IsAdded)
            {
                lblTitle.Text = $"បន្ថែមសិស្សនៅថ្នាក់​ {ClassRow.ClassName}";

                studentUUIDTextBox.Focus();
                cbGender.SelectedIndex = 0;

                StudentsRow = this.studentDbDataSet.Students.NewStudentsRow();
            }
            else
            {
                lblTitle.Text = $"កែប្រែព័ត៌មានសិស្សនៅថ្នាក់​ {ClassRow.ClassName}";

                //bind gender combo box
                cbGender.DataBindings.Add("Text", this.studentsBindingSource, "Gender");

                //import student row from different data set
                this.studentDbDataSet.Students.ImportRow(StudentsRow);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(Util.CheckValidDataTextBox(studentUUIDTextBox, "Student UUID") &&
                Util.CheckValidDataTextBox(firstNameTextBox, "First name") &&
                Util.CheckValidDataTextBox(lastNameTextBox, "Last name"))
            {
                //set field to student row
                SetStudentsRow(StudentsRow);

                if (IsAdded)
                {
                    //add one student row to data set
                    this.studentDbDataSet.Students.AddStudentsRow(StudentsRow);
                }

                try
                {
                    //save data to the database
                    this.studentsTableAdapter.Update(StudentsRow);
                }catch (SqlException ex)
                {
                    //remove the row from data set
                    this.studentDbDataSet.Students.RemoveStudentsRow(StudentsRow);

                    MessageBox.Show(
                        "Something went wrong with the field value! please check again",
                        "Warning", 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    studentUUIDTextBox.Focus();

                    return;
                }

                //close the form itself
                this.DialogResult = DialogResult.OK;
            }
        }

        private void SetStudentsRow(StudentDbDataSet.StudentsRow studentsRow)
        {
            if(studentsRow != null)
            {
                //generate random UUID
                //studentsRow.StudentUUID = Guid.NewGuid().ToString();

                studentsRow.StudentUUID = studentUUIDTextBox.Text; 
                studentsRow.FirstName = firstNameTextBox.Text;
                studentsRow.LastName = lastNameTextBox.Text;
                studentsRow.Gender = cbGender.Text;
                studentsRow.BirthDate = birthDateDateTimePicker.Value;
                if(!string.IsNullOrWhiteSpace(addressTextBox.Text))
                    studentsRow.Address = addressTextBox.Text;
                if(!string.IsNullOrWhiteSpace(telephoneTextBox.Text))
                    studentsRow.Telephone = telephoneTextBox.Text;
                studentsRow.IsActive = true;

                //from the selected class row
                studentsRow.ClassID = ClassRow.ClassID;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            studentUUIDTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            addressTextBox.Clear();
            telephoneTextBox.Clear();

            studentUUIDTextBox.Focus();
        }
    }
}
