using StudentOrganizer.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentOrganizer.DBOp
{
    
    public class StudentEventCommands
    {
        private string connectionString;
        private SqlConnection conn;

        public StudentEventCommands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertStudentEvent(StudentEvent studentEvent)
        {
            string insertString = @"INSERT INTO StudentEVENT(
                                                Id_Student,
                                                Id_Event ) 
                                                            values(
                                                            @Id_Student,@Id_Event)";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(insertString, conn);
                command.Parameters.Add("@idStudent", studentEvent.Id_Student);
                command.Parameters.Add("@idEvent", studentEvent.Id_Event);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateStudentEvent(StudentEvent studentEvent)
        {
            string updateString = @"UPDATE StudentEVENT 
                                           SET Id_Student = @Id_Student,
                                               Id_Event = @Id_Event , 
                                               WHERE id_Event = '" + studentEvent.Id_Event + "' and id_Student ='"+studentEvent.Id_Student+"'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@Id_Student", studentEvent.Id_Student);
                command.Parameters.Add("@Id_Event", studentEvent.Id_Event);
                command.ExecuteNonQuery();

                conn.Close();
            }

        }

        public void DeleteStudentEvent(StudentEvent studentEvent)
        {
            string deleteString = "DELETE FROM StudentEVENT WHERE id_Event = '" + studentEvent.Id_Event + "' and id_Student ='" + studentEvent.Id_Student + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }
    }
}