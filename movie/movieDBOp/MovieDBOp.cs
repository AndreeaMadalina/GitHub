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
    public class MovieDBOp
    {
        private string connectionString;
        private SqlConnection conn;

        public MovieDBOp(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void InsertEvent(MovieBO m)
        {
            string insertString = @"INSERT INTO Movie(
                                                Name,Genre,
                                                ReleaseYear,DirectorName,
                                                Storyline,Country,Language,Runtime) 
                                                            values(
                                                            @name,@genre,@releaseYear,
                                                            @directorName,@storyline,@country,
                                                            @language,@runtime
                                                                        )";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(insertString, conn);
                command.Parameters.Add("@name", m.Name);
                command.Parameters.Add("@genre", m.Genre);
                command.Parameters.Add("@releaseYear", m.ReleaseYear);
                command.Parameters.Add("@directorName", m.DirectorName);
                command.Parameters.Add("@storyline", m.Storyline);
                command.Parameters.Add("@country", m.Country);
                command.Parameters.Add("@language", m.Language);
                command.Parameters.Add("@runtime", m.Runtime);
                command.CommandType = CommandType.Text;
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void UpdateEvent(MovieBO m)
        {
            string updateString = @"UPDATE Movie
                                           SET 
                                                Name=@name,
                                                Genre=@genre,
                                                ReleaseYear=@releaseYear,
                                                DirectorName=@directorName,
                                                Storyline=@storyline,
                                                Country=@country,
                                                Language=@language,
                                                Runtime=@runtime
                                               WHERE id = '" + m.MovieID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(updateString, conn);

                command.Parameters.Add("@name", m.Name);
                command.Parameters.Add("@genre", m.Genre);
                command.Parameters.Add("@releaseYear", m.ReleaseYear);
                command.Parameters.Add("@directorName", m.DirectorName);
                command.Parameters.Add("@storyline", m.Storyline);
                command.Parameters.Add("@country", m.Country);
                command.Parameters.Add("@language", m.Language);
                command.Parameters.Add("@runtime", m.Runtime);

                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public void DeleteEvent(MovieBO m)
        {
            string deleteString = "DELETE FROM Movie WHERE id = '" + m.MovieID + "'";

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(deleteString, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
        }

        public MovieBO SearchEvent(int mID)
        {
            MovieBO m = new MovieBO();
            m.MovieID = mID;

            string searchString = "SELECT * FROM Movie where id = " + m.MovieID;

            using (conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(searchString, conn);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        m.Name = reader.GetString(reader.GetOrdinal("Name"));
                        m.Genre = reader.GetString(reader.GetOrdinal("Genre"));
                        m.ReleaseYear = reader.GetInt32(reader.GetOrdinal("ReleaseYear"));
                        m.DirectorName = reader.GetString(reader.GetOrdinal("DirectorName"));
                        m.Storyline = reader.GetString(reader.GetOrdinal("Storyline"));
                        m.Country = reader.GetString(reader.GetOrdinal("Country"));
                        m.Language = reader.GetString(reader.GetOrdinal("Language"));
                        m.Runtime = reader.GetInt32(reader.GetOrdinal("Runtime"));
                    }
                }

                conn.Close();
            }

            return m;
        }
    }
}
