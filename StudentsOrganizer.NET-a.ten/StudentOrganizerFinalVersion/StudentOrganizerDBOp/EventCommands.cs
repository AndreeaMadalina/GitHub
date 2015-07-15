using StudentOrganizer.BO;
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
    public class EventCommands
    {
        private string connectionString;
        private SqlConnection conn;

        public EventCommands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertEvent(Event ev)
        {
            string insertString = @"INSERT INTO Events(
                                                Period,
                                                Department,Task,
                                                Remarks,event_Type_ID) 
                                                            values(
                                                            @period,@departament,
                                                            @task,@remarks,@event_Type_ID
                                                                        )";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(insertString, conn);
                command.Parameters.Add("@period", ev.Period);
                command.Parameters.Add("@departament", ev.Department);
                command.Parameters.Add("@task", ev.Task);
                command.Parameters.Add("@remarks", ev.Remarks);
                command.Parameters.Add("@event_Type_ID", ev.Event_Type_ID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEvent(Event ev)
        {
            string updateString = @"UPDATE EVENTS
                                           SET 
                                               Period=@period, 
                                               Department=@departament, 
                                               Task=@task, 
                                               Remarks=@remarks ,
                                               event_Type_ID = @event_Type_ID
                                               WHERE id = '" + ev.IdEvent + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@period", ev.Period);
                command.Parameters.Add("@departament", ev.Department);
                command.Parameters.Add("@task", ev.Task);
                command.Parameters.Add("@remarks", ev.Remarks);
                command.Parameters.Add("@event_Type_ID", ev.Event_Type_ID);

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void DeleteEvent(Event ev)
        {
            string deleteString = "DELETE FROM EVENTS WHERE id = '" + ev.IdEvent + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public Event SearchEvent(int evID)
        {
            Event ev = new Event();
            ev.IdEvent = evID;

            string searchString = "SELECT * FROM EVENTS where id = " + ev.IdEvent;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ev.Period = reader.GetString(reader.GetOrdinal("Period"));
                        ev.Remarks = reader.GetString(reader.GetOrdinal("Remarks"));
                        ev.Task = reader.GetString(reader.GetOrdinal("Task"));
                        ev.Department = reader.GetString(reader.GetOrdinal("Departament"));
                        ev.Event_Type_ID = reader.GetInt32(reader.GetOrdinal("event_Types_ID"));
                    }
                }

                conn.Close();
            }

            return ev;
        }
    }
}