using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementAndReport.Students
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            //load data from the database
            this.classTableAdapter.Fill(this.studentDbDataSet.Class);

            //load initial data
            this.studentsTableAdapter.FillByClassID(this.studentDbDataSet.Students,
                         (int)cbChooseClass.SelectedValue);

            ShowToolStripInfo(); 

            this.studentsBindingSource.ListChanged += StudentsBindingSource_ListChanged;
        }

        private void StudentsBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            ShowToolStripInfo();
        }

        private void cbChooseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChooseClass.SelectedValue == null) return;

            //load data from table students
            this.studentsTableAdapter.FillByClassID(this.studentDbDataSet.Students,
                (int) cbChooseClass.SelectedValue);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            //select class row from combo box
            DataRowView classDataRowView = (DataRowView) cbChooseClass.SelectedItem;

            if (classDataRowView != null)
            {
                StudentDbDataSet.ClassRow selectedClassRow = 
                    (StudentDbDataSet.ClassRow) classDataRowView.Row;

                FrmAddOrModifyStudent frmAddOrModifyStudent = new FrmAddOrModifyStudent()
                {
                    IsAdded = true,
                    ClassRow = selectedClassRow
                };

                frmAddOrModifyStudent.ShowDialog();

                if(frmAddOrModifyStudent.DialogResult == DialogResult.OK) 
                {
                    //import student row from different data set
                    this.studentDbDataSet.Students.ImportRow(frmAddOrModifyStudent.StudentsRow);
                }

                return;
            }

            MessageBox.Show("Please select the specific class!",
                "Warning",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning); 
        }

        private void dgvShowStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //column index = 10; 
            if (e.RowIndex == -1) return; 

            if (e.ColumnIndex == 10)
            {
                //select class row from combo box
                DataRowView classDataRowView = (DataRowView)cbChooseClass.SelectedItem;

                //select student row from dgv
                DataRowView studentDataRowView = this.studentsBindingSource.Current as DataRowView; 

                if (classDataRowView != null && studentDataRowView != null)
                {
                    StudentDbDataSet.ClassRow selectedClassRow =
                        (StudentDbDataSet.ClassRow)classDataRowView.Row;

                    StudentDbDataSet.StudentsRow selectedStudentRow =
                        (StudentDbDataSet.StudentsRow)studentDataRowView.Row;

                    FrmAddOrModifyStudent frmAddOrModifyStudent = new FrmAddOrModifyStudent()
                    {
                        IsAdded = false,
                        ClassRow = selectedClassRow,
                        StudentsRow = selectedStudentRow
                    };

                    frmAddOrModifyStudent.ShowDialog();

                    return;
                }
            }

            if (e.ColumnIndex == 11)
            {
                //select student row from dgv
                DataRowView studentDataRowView = this.studentsBindingSource.Current as DataRowView;

                if (studentDataRowView != null)
                {
                    StudentDbDataSet.StudentsRow selectedStudentRow =
                        studentDataRowView.Row as StudentDbDataSet.StudentsRow;

                    DialogResult result = MessageBox.Show(
                        $"Are you sure to delete the row with student UUID, {selectedStudentRow.StudentUUID}?",
                        "Confirmation",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question); 

                    if (result == DialogResult.OK) 
                    {
                        //delete from data set
                        selectedStudentRow.Delete();
                        //this.studentsBindingSource.RemoveCurrent();

                        //save data to the database
                        this.studentsTableAdapter.Update(this.studentDbDataSet.Students);

                        ShowToolStripInfo();
                    }
                }
            }
        }

        private void ShowToolStripInfo()
        {
            try
            {
                toolStripLblTotalStudent.Text = this.studentDbDataSet.Students.Count.ToString();
                toolStripLblTotalMale.Text = this.studentDbDataSet.Students.Count(student => student.Gender.Equals("ប្រុស")).ToString();
                toolStripLblTotalFemale.Text = this.studentDbDataSet.Students.Count(student => student.Gender.Equals("ស្រី")).ToString();
            }catch(DeletedRowInaccessibleException ex)
            {
                return;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            //load initial data
            this.studentsTableAdapter.FillByClassID(this.studentDbDataSet.Students,
                         (int)cbChooseClass.SelectedValue);
        }

        private void dgvShowStudent_Paint(object sender, PaintEventArgs e)
        {
            if (dgvShowStudent.Rows.Count == 0)
            {
                TextRenderer.DrawText(
                    e.Graphics,
                    $"គ្មានព័ត៌មានសិស្សនៅថ្នាក់ {cbChooseClass.Text}......",
                    dgvShowStudent.Font,
                    dgvShowStudent.ClientRectangle,
                    dgvShowStudent.ForeColor,
                    dgvShowStudent.BackgroundColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }
    }
}
