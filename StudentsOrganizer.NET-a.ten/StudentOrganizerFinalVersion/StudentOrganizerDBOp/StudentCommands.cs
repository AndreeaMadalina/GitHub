using StudentOrganizer.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizerDBOp
{
    public class StudentCommands
    {
        private SqlConnection conn;
        private string connectionString;

        public StudentCommands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertStudent(StudentOrganizer.BO.Student stud)
        {
            string insertString = @"INSERT INTO STUDENT(
                                        FirstName,
                                        LastName,
                                        Gender,
                                        Email,
                                        BirthDate,
                                        PhoneNumber,
            Faculty,FacultyStartYear) values(@firstName,@lastName,@gender,@email,@birthDate,@phoneNumber,@faculty,@facultyStartYear)";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(insertString, conn);

                command.Parameters.Add("@firstName", stud.FirstName);
                command.Parameters.Add("@lastName", stud.LastName);
                command.Parameters.Add("@gender", stud.Gender);
                command.Parameters.Add("@email", stud.Email);
                command.Parameters.Add("@birthDate", stud.BirthDate);
                command.Parameters.Add("@phoneNumber", stud.PhoneNumber);
                command.Parameters.Add("@faculty", stud.Faculty);
                command.Parameters.Add("@facultyStartYear", stud.FacultyStartYear);
                command.CommandType = CommandType.Text;

                command.ExecuteNonQuery();
                conn.Close();
            }

        }

        public void UpdateStudent(StudentOrganizer.BO.Student stud)
        {
            string updateString = "UPDATE STUDENT SET FirstName = @firstName,LastName = @lastName, Gender=@gender,Email = @email, BirthDate=@birthDate, PhoneNumber = @phoneNumber, Faculty = @faculty, FacultyStartYear = @facultyStartYear WHERE student.id = '" + stud.IdStudent + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@firstName", stud.FirstName);
                command.Parameters.Add("@lastName", stud.LastName);
                command.Parameters.Add("@gender", stud.Gender);
                command.Parameters.Add("@email", stud.Gender);
                command.Parameters.Add("@birthDate", stud.BirthDate);
                command.Parameters.Add("@phoneNumber", stud.PhoneNumber);
                command.Parameters.Add("@faculty", stud.Faculty);
                command.Parameters.Add("@facultyStartYear", stud.FacultyStartYear);
                command.ExecuteNonQuery();

                conn.Close();
            }

        }

        public void DeleteStudent(Student stud)
        {
            string deleteString = "DELETE FROM Student WHERE id = '" + stud.IdStudent + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }

        public StudentOrganizer.BO.Student SearchStudent(int studID)
        {
            StudentOrganizer.BO.Student student = new StudentOrganizer.BO.Student();
            student.IdStudent = studID;

            string searchString = "SELECT * FROM student where id = " + student.IdStudent;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        student.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        student.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                        student.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                        student.Gender = reader.GetString(reader.GetOrdinal("Email"));
                        student.BirthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                        student.PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber"));
                        student.Faculty = reader.GetString(reader.GetOrdinal("Faculty"));
                        student.FacultyStartYear = reader.GetString(reader.GetOrdinal("FacultyStartYear"));
                    }
                    reader.Close();
                }

                conn.Close();
            }

            return student;
        }
    }
}
