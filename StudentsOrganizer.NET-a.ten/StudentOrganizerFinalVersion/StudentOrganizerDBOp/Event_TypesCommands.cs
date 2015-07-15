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
    public class Event_TypesCommands
    {
        private string connectionString;
        private SqlConnection conn;

        public Event_TypesCommands(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertEventTypes(Event_Types ev)
        {
            string insertString = "INSERT INTO EventTypes(Description) values(@description)";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertString, conn);

                command.Parameters.Add("@description", ev.Description);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEventTypes(Event_Types ev)
        {
            string updateString = "UPDATE EventTypes SET Description = @description WHERE event.id = '" + ev.Id + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(updateString, conn);
                command.Parameters.Add("@description", ev.Description);
                command.ExecuteNonQuery();

                conn.Close();
            }

        }

        public void DeleteEventTypes(Event_Types ev)
        {
            string deleteString = "DELETE FROM EventTypes WHERE id = '" + ev.Id + "'";
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public List<Event_Types> GetEventTypes()
        {
            Event_Types ev = new Event_Types();
            List<Event_Types> eventList = new List<Event_Types>();

            string selectString = "SELECT * FROM EventTypes ";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(selectString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ev.Description = reader.GetString(reader.GetOrdinal("Name"));
                        ev.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        eventList.Add(ev);
                    }
                }

                conn.Close();
            }

            return eventList;
        }

        public Event_Types SearchEventTypes(int evID)
        {
            Event_Types ev = new Event_Types();
            ev.Id = evID;

            string searchString = "SELECT * FROM EventTypes where id = " + ev.Id;
            
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ev.Description = reader.GetString(reader.GetOrdinal("Description"));
                    }
                }

                conn.Close();
            }

            return ev;
        }
    }
}