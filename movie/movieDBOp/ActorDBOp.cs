using movieBO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace movieDBOp
{
    public class ActorDBOp
    {
        private string connectionString;
        private SqlConnection conn;

        public ActorDBOp(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertEvent(ActorBO ac)
        {
            string insertString = @"INSERT INTO Actor(
                                                FirstName,
                                                LastName,
                                                DateOfBirth) 
                                                            values(
                                                            @firstName,@lastName,
                                                            @dateOfBirth
                                                                        )";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertString, conn);

                command.Parameters.Add("@firstName", ac.FirstName);
                command.Parameters.Add("@lastName", ac.LastName);
                command.Parameters.Add("@dateOfBirth", ac.DateOfBirth);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEvent(ActorBO ac)
        {
            string updateString = @"UPDATE Actor
                                           SET 
                                               FirstName=@firstName, 
                                               LastName=@lastName, 
                                               DateOfBirth=@dateOfBirth
                                               WHERE id = '" + ac.ActorID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@firstName", ac.FirstName);
                command.Parameters.Add("@lastName", ac.LastName);
                command.Parameters.Add("@dateOfBirth", ac.DateOfBirth);

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void DeleteEvent(ActorBO ac)
        {
            string deleteString = "DELETE FROM Actor WHERE id = '" + ac.ActorID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public ActorBO SearchEvent(int acID)
        {
            ActorBO ac = new ActorBO();
            ac.ActorID = acID;

            string searchString = "SELECT * FROM Actor where id = " + ac.ActorID;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ac.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        ac.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                        ac.DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth"));
                    }
                }

                conn.Close();
            }

            return ac;
        }

    }
}
