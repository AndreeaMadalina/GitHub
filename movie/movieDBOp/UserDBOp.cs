using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using movieBO;
using System.Data;
using System.Data.SqlClient;

namespace movieDBOp
{
    public class UserDBOp
    {
        private string connectionString;
        private SqlConnection conn;

        public UserDBOp(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertEvent(UserBO u)
        {
            string insertString = @"INSERT INTO User(
                                                Username,Password,
                                                Email,FirstName,
                                                LastName,JoinDate) 
                                                            values(
                                                            @username,@password,@email,
                                                            @firstName,@lastName,@joinDate
                                                                        )";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertString, conn);

                command.Parameters.Add("@username", u.Username);
                command.Parameters.Add("@password", u.Password);
                command.Parameters.Add("@email", u.Email);
                command.Parameters.Add("@firstName", u.FirstName);
                command.Parameters.Add("@lastName", u.LastName);
                command.Parameters.Add("@joinDate", u.JoinDate);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEvent(UserBO u)
        {
            string updateString = @"UPDATE User
                                           SET 
                                                Username=@username,
                                                Password=@password,
                                                Email=@email;
                                                FirstName=@firstName,
                                                LastName=@lastName,
                                                JoinDate=@joinDate
                                               WHERE id = '" + u.UserID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@username", u.Username);
                command.Parameters.Add("@password", u.Password);
                command.Parameters.Add("@email", u.Email);
                command.Parameters.Add("@firstName", u.FirstName);
                command.Parameters.Add("@lastName", u.LastName);
                command.Parameters.Add("@joinDate", u.JoinDate);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void DeleteEvent(UserBO u)
        {
            string deleteString = "DELETE FROM User WHERE id = '" + u.UserID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public UserBO SearchUser(int uID)
        {
            UserBO u = new UserBO();
            u.UserID = uID;

            string searchString = "SELECT * FROM User where id = " + u.UserID;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        u.Username = reader.GetString(reader.GetOrdinal("Username"));
                        u.Password = reader.GetString(reader.GetOrdinal("Password"));
                        u.Email = reader.GetString(reader.GetOrdinal("Email"));
                        u.FirstName = reader.GetString(reader.GetOrdinal("FirstName"));
                        u.LastName = reader.GetString(reader.GetOrdinal("LastName"));
                        u.JoinDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"));
                    }
                }

                conn.Close();
            }

            return u;
        }
    }
}
