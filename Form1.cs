using EntityFrameworkSample.Business;
using EntityFrameworkSample.Core;
using EntityFrameworkSample.Core.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EntityFrameworkSample
{
    public partial class Form1 : Form
    {
        UnitOfWork _uow = new UnitOfWork();
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        #region Functions

        public void Setup()
        {
            isValidUpdate();
            isValidSave();
            isValidFindDelete();
            updateGradeBtn.Enabled = false;
        }
        public void SaveStudent()
        {
            Student student = new Student()
            {
                StudentName = textBoxName.Text,
                StudentSurname = textBoxSurname.Text
            };
            dataGridViewList.DataSource = _uow.Insert(student);
        }
        public void GetTable(string tableName)
        {
            if (tableName == "Student")
            {
                dataGridViewList.DataSource = _uow.StudentList();

            }
            else if (tableName == "Lecture")
            {
                dataGridViewList.DataSource = _uow.LectureList();
                
            }
            else if (tableName == "Grade")
            {
                dataGridViewList.DataSource = _uow.GradesList();
            }
            else
                MessageBox.Show("Wrong table name!");
        }
        public void UpdateStudent()
        {
            string studentName = textBoxName.Text;
            string studentSurname = textBoxSurname.Text;
            int studentID = Convert.ToInt32(textBoxID.Text);
            _uow.Update(_uow.Find(studentID), studentName, studentSurname);
        }
        public List<Student> FindStudent()
        {
            List<Student> resultTable = new List<Student>();
            var resultStudent = _uow.Find(Convert.ToInt32(textBoxID.Text));
            resultTable.Add(resultStudent);
            return resultTable;
        }
        public void isValidSave()
        {
            if(string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxSurname.Text))
            {
                saveBtn.Enabled = false;
            }
            else
            {
                saveBtn.Enabled = true;
            }
        }
        public void isValidUpdate()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxSurname.Text) || string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                updateBtn.Enabled = false;
            }
            else
            {
                updateBtn.Enabled = true;
            }
        }
        public void isValidFindDelete()
        {
            if (string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                findBtn.Enabled = false;
                deleteBtn.Enabled = false;
            }
            else
            {
                findBtn.Enabled = true;
                deleteBtn.Enabled = true;
            }
        }
        public void DisableButtons()
        {
            saveBtn.Enabled = false;
            deleteBtn.Enabled = false;
            studentBtn.Enabled = false;
            lecturesBtn.Enabled = false;
            updateBtn.Enabled = false;
            findBtn.Enabled = false;
            gradesBtn.Enabled = false;
            procedureBtn.Enabled = false;
            textBoxName.Enabled = false;
            textBoxSurname.Enabled = false;
            textBoxID.Enabled = false;
            textBoxState.Enabled = false;
            textBoxAVG.Enabled = false;
            textBoxGrade1.Enabled = true;
            textBoxGrade2.Enabled = true;
        }
        public void EnableButtons()
        {
            studentBtn.Enabled = true;
            lecturesBtn.Enabled = true;
            gradesBtn.Enabled = true;
            procedureBtn.Enabled = true;
            textBoxName.Enabled = true;
            textBoxName.Clear();
            textBoxSurname.Enabled = true;
            textBoxSurname.Clear();
            textBoxID.Enabled = true;
            textBoxID.Clear();
            textBoxGrade1.Enabled = false;
            textBoxGrade1.Clear();
            textBoxGrade2.Enabled = false;
            textBoxGrade2.Clear();
            textBoxAVG.Clear();
            textBoxState.Clear();
            updateGradeBtn.Enabled = false;
        }
        public void Calculate()
        {
            int grade1, grade2,avg;
            bool state;
            grade1 = Convert.ToInt32(textBoxGrade1.Text);
            grade2 = Convert.ToInt32(textBoxGrade2.Text);

            avg = (grade1 + grade2) / 2;
            textBoxAVG.Text = avg.ToString();
            if (avg >= 50)
            {
                state = true;
                textBoxState.Text = "Passed";
            }
            else
            {
                state = false;
                textBoxState.Text = "Failed";
            }
        }
        public void UpdateGrade()
        {
            int gradeID = Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value);
            var currentGrade = _uow.FindGrade(gradeID);
            int grade1 = Convert.ToInt32(textBoxGrade1.Text);
            int grade2 = Convert.ToInt32(textBoxGrade2.Text);
            int average = (grade1 + grade2) / 2;
            bool success = average >= 50;
            dataGridViewList.DataSource = _uow.Update(currentGrade, grade1, grade2, average, success);
        }
        #endregion

        #region Buttons
        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveStudent();
        }
        private void studentBtn_Click(object sender, EventArgs e)
        {
            GetTable("Student");
        }
        private void lecturesBtn_Click(object sender, EventArgs e)
        {
            GetTable("Lecture");
        }
        private void gradesBtn_Click(object sender, EventArgs e)
        {
            GetTable("Grade");
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            _uow.Delete(FindStudent()[0]);
            GetTable("Student");
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateStudent();
            GetTable("Student");
        }
        private void findBtn_Click(object sender, EventArgs e)
        {
            dataGridViewList.DataSource = FindStudent();
        }


        #endregion

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            isValidSave();
            isValidUpdate();
        }
        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            isValidSave();
            isValidUpdate();
        }
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            isValidUpdate();
            isValidFindDelete();
        }
        private void procedureBtn_Click(object sender, EventArgs e)
        {
            dataGridViewList.DataSource = _uow.GetProcedure();
        }

        private void dataGridViewList_Click(object sender, EventArgs e)
        {
            if(dataGridViewList.SelectedRows.Count > 0 && dataGridViewList.DataSource.GetType().ToString() == "System.Collections.Generic.List`1[<>f__AnonymousType1`7[System.Int32,System.String,System.String,System.Int32,System.Int32,System.Int32,System.Boolean]]")
            {
                int gradeID,average,grade1,grade2;
                bool state;

                gradeID = Convert.ToInt32(dataGridViewList.CurrentRow.Cells[0].Value);

                var gradeTable = _uow.FindGrade(gradeID);

                grade1 = gradeTable.Grade1;
                grade2 = gradeTable.Grade2;
                textBoxGrade1.Text = grade1.ToString();
                textBoxGrade2.Text =grade2.ToString();
                var studentTable = _uow.Find(gradeTable.StudentID);
                textBoxName.Text = studentTable.StudentName;
                textBoxSurname.Text = studentTable.StudentSurname;
                textBoxID.Text = studentTable.StudentID.ToString();

                DisableButtons();

                average = (grade1 + grade2) / 2;

                if (average >= 50)
                {
                    state = true;
                    textBoxState.Text = "Passed";
                }
                else
                {
                    state = false;
                    textBoxState.Text = "Failed"; 
                }

                textBoxAVG.Text = average.ToString();
                updateGradeBtn.Enabled = true;
            }
            else
                updateGradeBtn.Enabled = false;

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            EnableButtons();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void updateGradeBtn_Click(object sender, EventArgs e)
        {
            UpdateGrade();
        }
    }
}
