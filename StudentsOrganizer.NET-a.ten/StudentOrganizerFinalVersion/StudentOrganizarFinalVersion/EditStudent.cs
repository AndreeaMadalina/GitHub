using StudentOrganizer.BO;
using StudentOrganizerDBOp;
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
    public partial class EditStudent : Form
    {
        Student stud;
        StudentCommands studComm;

        public EditStudent(Student stud)
        {
            InitializeComponent();
            
            this.stud = stud;
            studComm = new StudentCommands(Properties.Settings.Default.connection);

            
            FirstNameTextEdit.Text = stud.FirstName;
            LastNameTextEdit.Text = stud.LastName;
            PhoneNumberTextEdit.Text = stud.PhoneNumber;
            BirthDateTextEdit.Text = "" + stud.BirthDate;
            FacultyTextEdit.Text = stud.Faculty;
            FacultyStartTextEdit.Text = stud.FacultyStartYear;
            EmailTextEdit.Text = stud.Email;


            if (stud.Gender.Equals("Male"))
            {
                MaleButton.Checked = true;
                FemaleButton.Checked = false;
            }
            else
            {
                MaleButton.Checked = false;
                FemaleButton.Checked = true;
            }
        }

        private void FirstNameTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveButtonEditStudent_Click(object sender, EventArgs e)
        {
            stud.FirstName = FirstNameTextEdit.Text;
            stud.LastName = LastNameTextEdit.Text;
            stud.BirthDate = Convert.ToDateTime(BirthDateTextEdit.Text);
            stud.PhoneNumber = PhoneNumberTextEdit.Text;
            stud.Faculty = FacultyTextEdit.SelectedText;
            stud.FacultyStartYear = FacultyStartTextEdit.SelectedText;
            stud.Email = EmailTextEdit.Text;

            studComm.UpdateStudent(stud);

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

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            stud.Gender = "Male";
            FemaleButton.Checked = false;
        }

        private void FemaleButton_CheckedChanged(object sender, EventArgs e)
        {
            stud.Gender = "Female";
            MaleButton.Checked = false;
        }

        private void BackButton_CheckedChanged(object sender, EventArgs e)
        {
            List andrei = new List();
            andrei.Show();
            this.Hide();
        }

        
    }
}
