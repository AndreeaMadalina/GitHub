using StudentOrganizer.BO;
using StudentOrganizer.DBOp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentOrganizarFinalVersion
{
    public partial class Create : Form
    {
        private Student student;
        private StudentOrganizerDBOp.StudentCommands studComm;
        private Event eventToAdd;
        private EventCommands eventComm;
        public Create()
        {
            InitializeComponent();

            student = new Student();
            studComm = new StudentOrganizerDBOp.StudentCommands(Properties.Settings.Default.connection);
            eventToAdd = new Event();
            eventComm = new EventCommands(Properties.Settings.Default.connection);
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveButtonCreateStudent_Click(object sender, EventArgs e)
        {
            student.FirstName = FirstNameTextEdit.Text;
            student.LastName = LastNameTextEdit.Text;
            student.BirthDate = Convert.ToDateTime(BirthDateTextEdit.Text);
            student.PhoneNumber = PhoneNumberTextEdit.Text;
            student.Faculty = FacultyTextEdit.SelectedText;
            student.FacultyStartYear = FacultyStartTextEdit.SelectedText;
            student.Email = EmailTextEdit.Text;

            studComm.InsertStudent(student);

            FirstNameTextEdit.Text = string.Empty;
            LastNameTextEdit.Text = string.Empty;
            BirthDateTextEdit.Text = string.Empty;
            PhoneNumberTextEdit.Text = string.Empty;
            FacultyTextEdit.Text = string.Empty;
            EmailTextEdit.Text = string.Empty;
            FacultyStartTextEdit.Text = string.Empty;
            FemaleButton.Checked = false;
            MaleButton.Checked = false;
            

        }

        private void BirthDateTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Male";
            FemaleButton.Checked = false;
        }

        private void checkEdit2_CheckedChanged(object sender, EventArgs e)
        {
            student.Gender = "Female";
            MaleButton.Checked = false;
        }

        private void BackButton_CheckedChanged(object sender, EventArgs e)
        {
            MainPage andrei = new MainPage();
            andrei.Show();

            this.Hide();
        }

        private void labelControl11_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            MainPage andrei = new MainPage();
            andrei.Show();

            this.Hide();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            eventToAdd.Period = PeriodTextEdit.Text;
            eventToAdd.Department= DepartmentTextEdit.Text;
            eventToAdd.Task = TaskTextEdit.Text;
            eventToAdd.Remarks = RemarksTextEdit.Text;
            eventToAdd.Event_Type_ID = Convert.ToInt32(EventTypeTextEdit.Text);

            eventComm.InsertEvent(eventToAdd);

            PeriodTextEdit.Text = string.Empty;
            DepartmentTextEdit.Text = string.Empty;
            TaskTextEdit.Text = string.Empty;
            RemarksTextEdit.Text = string.Empty;
            EventTypeTextEdit.Text = string.Empty;
            
        }

        private void PeriodTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }

        private void RemarksTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void TaskTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void EventTypeTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void labelControl9_Click(object sender, EventArgs e)
        {

        }
    }
}
