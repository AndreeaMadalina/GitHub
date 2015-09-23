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
    public class RatingDBOp
    {
        private string connectionString;
        private SqlConnection conn;

        public RatingDBOp(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertRating(RatingBO r)
        {
            string insertString = @"INSERT INTO Raiting(
                                                Rating,MovieID,UserID)
                                                        values(
                                                        @rating,@movieID,@userID
                                                        )";
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(insertString, conn);

                command.Parameters.Add("@rating", r.Rating);
                command.Parameters.Add("@movieID", r.MovieID);
                command.Parameters.Add("@userID", r.UserID);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateRating(RatingBO r)
        {
            string updateString = @"UPDATE Rating
                                        SET
                                            Rating=@rating,
                                            MovieID=@movieID,
                                            ActorID=@actorID
                                            WHERE id = '" + r.RatingID + "'";
            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@rating", r.Rating);
                command.Parameters.Add("@movieID", r.MovieID);
                command.Parameters.Add("@userID", r.UserID);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void DeleteRating(RatingBO r)
        {
            string deleteString = "DELETE FROM Rating WHERE id = '" + r.RatingID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public RatingBO SearchRating(int rID)
        {
            RatingBO r = new RatingBO();
            r.RatingID = rID;

            string searchString = "SELECT * FROM Rating where id = " + r.RatingID;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        r.MovieID = reader.GetInt32(reader.GetOrdinal("MovieID"));
                        r.UserID = reader.GetInt32(reader.GetOrdinal("UserID"));
                    }
                }

                conn.Close();
            }

            return r;
        }
        
    }
}
