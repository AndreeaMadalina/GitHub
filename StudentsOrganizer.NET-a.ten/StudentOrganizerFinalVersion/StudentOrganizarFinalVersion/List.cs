using DevExpress.XtraGrid;
using StudentOrganizer.BO;
using StudentOrganizerDBOp;
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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;

namespace StudentOrganizarFinalVersion
{
    public partial class List : Form
    {
        Event event1;
        Student stud;
        SqlDataAdapter sda;
        SqlCommandBuilder scb;
        DataTable dt;
        StudentCommands studComm;
        SqlConnection connection;
        public List()
        {
            InitializeComponent();
            CreateDataTable();
            CreateEventTable();
            stud = new Student();
            event1 = new Event();
            studComm = new StudentCommands(Properties.Settings.Default.connection);
            
        }

        public void CreateDataTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(StudentOrganizarFinalVersion.Properties.Settings.Default.connection);
            connection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(@"SELECT ID,FirstName,
                                                            LastName,Gender,BirthDate,
                                                            Email,PhoneNumber,Faculty,
                                                            FacultyStartYear FROM Student", connection);
            sqlAdapter.Fill(dataTable);
            
            GridControl.DataSource = dataTable;
        }

        private void CreateButton(object sender, EventArgs e)
        {
            Create andrei = new Create();
            andrei.Show();

            this.Hide();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            CreateDataTable();
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void CreateEventTable()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(StudentOrganizarFinalVersion.Properties.Settings.Default.connection);
            connection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(@"SELECT ID,Period,
                                                            Department,Task,Remarks,
                                                            Event_type_id FROM Events", connection);
            sqlAdapter.Fill(dataTable);

            gridControl1.DataSource = dataTable;
        }

       

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            Create andrei = new Create();
            andrei.Show();

            this.Hide();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            Create andrei = new Create();
            andrei.Show();

            this.Hide();
        }

      

        public void EditStudentButton_Click(object sender, EventArgs e)
        {
            
            var rowHandler = gridView3.FocusedRowHandle;
            
            //stud.IdStudent = Convert.ToInt32(gridView3.GetRowCellValue(rowHandler, "id"));
            stud.FirstName = gridView3.GetRowCellValue(rowHandler, "FirstName").ToString();
            stud.LastName = gridView3.GetRowCellValue(rowHandler, "LastName").ToString();
            stud.Gender = gridView3.GetRowCellValue(rowHandler, "Gender").ToString();
            stud.BirthDate = Convert.ToDateTime(gridView3.GetRowCellValue(rowHandler, "BirthDate").ToString());
            stud.Email = gridView3.GetRowCellValue(rowHandler, "Email").ToString();
            stud.PhoneNumber = gridView3.GetRowCellValue(rowHandler, "PhoneNumber").ToString();
            stud.Faculty = gridView3.GetRowCellValue(rowHandler, "Faculty").ToString();
            stud.FacultyStartYear = Convert.ToInt32(gridView3.GetRowCellValue(rowHandler, "FacultyStartYear")).ToString();

            EditStudent andrei = new EditStudent(stud);
            andrei.Show();

            this.Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            var rowHandler = gridView3.FocusedRowHandle;

            stud.IdStudent = Convert.ToInt32(gridView3.GetRowCellValue(rowHandler, "id"));
            stud.FirstName = gridView3.GetRowCellValue(rowHandler, "FirstName").ToString();
            stud.LastName = gridView3.GetRowCellValue(rowHandler, "LastName").ToString();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the student : " + stud.FirstName + " " + stud.LastName, "Delete Student?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                studComm.DeleteStudent(stud);

                dt = new DataTable();
                connection = new SqlConnection(Properties.Settings.Default.connection);
                sda = new SqlDataAdapter(@"SELECT id,firstName,
                                                            lastName,gender,birthDate,
                                                            email,phoneNumber,faculty,
                                                            facultyStartYear FROM Student", connection);
                sda.Fill(dt);
                GridControl.DataSource = dt;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void EditButton2_Click(object sender, EventArgs e)
        {
            var rowHandler = gridView2.FocusedRowHandle;

            //stud.IdStudent = Convert.ToInt32(gridView3.GetRowCellValue(rowHandler, "id"));
            event1.Period = gridView2.GetRowCellValue(rowHandler, "Period").ToString();
            event1.Department = gridView2.GetRowCellValue(rowHandler, "Department").ToString();
            event1.Task = gridView2.GetRowCellValue(rowHandler, "Task").ToString();
            event1.Remarks = gridView2.GetRowCellValue(rowHandler, "Remarks").ToString();
            event1.Event_Type_ID = Convert.ToInt32(gridView2.GetRowCellValue(rowHandler, "Event_Type_ID"));
            
            

            EditEvent andrei = new EditEvent(event1);
            andrei.Show();

            this.Hide();
        }

        private void GridControl_Click(object sender, EventArgs e)
        {

        }

        
    }
}
