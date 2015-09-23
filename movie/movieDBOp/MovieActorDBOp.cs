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
    public class MovieActorDBOp
    {
        private string connectionString;
        private SqlConnection conn;

        public MovieActorDBOp(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertEvent(MovieActorBO ma)
        {
            string insertString = @"INSERT INTO MovieActor(
                                                MovieID,
                                                ActorID) 
                                                            values(
                                                            @movieID,@actorID
                                                                        )";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertString, conn);

                command.Parameters.Add("@movieID", ma.MovieID);
                command.Parameters.Add("@actorID", ma.ActorID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEvent(MovieActorBO ma)
        {
            string updateString = @"UPDATE MovieActor
                                           SET 
                                               MovieID=@movieID, 
                                               ActorID=@actorID
                                               WHERE id = '" + ma.MovieActorID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@movieID", ma.MovieID);
                command.Parameters.Add("@actorID", ma.ActorID);

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void DeleteEvent(MovieActorBO ma)
        {
            string deleteString = "DELETE FROM MovieActor WHERE id = '" + ma.MovieActorID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public MovieActorBO SearchEvent(int maID)
        {
            MovieActorBO ma = new MovieActorBO();
            ma.MovieActorID = maID;

            string searchString = "SELECT * FROM MovieActor where id = " + ma.MovieActorID;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ma.MovieID = reader.GetInt32(reader.GetOrdinal("MovieID"));
                        ma.ActorID = reader.GetInt32(reader.GetOrdinal("ActorID"));
                    }
                }

                conn.Close();
            }

            return ma;
        }
    }
}
