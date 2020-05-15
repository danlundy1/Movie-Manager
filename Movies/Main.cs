/* Daniel Lundy
 * 05/03/2020
 * CSCI 1630
 * Movie Manager
 * 
 * This is the Main.cs for Movie Manager.  The purpose of Main.cs is to display the database in a DataGridView control.
 * The Title, Year, Director, Genre, and TotalEarned will be displayed.  Main.cs also contains the MenuStrip which is how
 * the other forms are accessed and the data is refreshed after creating, updating, or deleting an entry. 
 */




using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Movies;

namespace Movie
{
    public partial class Main : Form

    { 
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            List<Movie> movies = new List<Movie>();
            string[] genres = { "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
            string sqlCommand = "Select Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies ORDER BY Title";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movie = new Movie();
                                movie.Title = reader.GetString(1);
                                movie.Year = reader.GetInt32(2);
                                movie.Director = reader.GetString(3);
                                int genreNumber = reader.GetInt32(4);
                                if (genreNumber > 8 || genreNumber < 0)
                                {
                                    movie.Genre = "undefined";
                                }
                                else
                                {
                                    movie.Genre = genres[genreNumber];
                                }
                                if (!reader.IsDBNull(5))
                                {
                                    movie.RottenTomatoesScore = reader.GetInt32(5);
                                }
                                else
                                {
                                    movie.RottenTomatoesScore = 0;
                                }
                                if (!reader.IsDBNull(6))
                                {
                                    movie.TotalEarned = reader.GetDecimal(6);
                                }
                                else
                                {
                                    movie.TotalEarned = 0;
                                }
                                movies.Add(movie);
                            }
                        }
                        connection.Close();
                        
                        MoviesListDataGridView.DataSource = movies;
                        MoviesListDataGridView.Columns[5].DefaultCellStyle.Format = "C2";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed. {ex.Message }");
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            //ShowDialog makes the form modal
            form.ShowDialog(this);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RefreshListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            List<Movie> movies = new List<Movie>();
            string[] genres = { "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
            string sqlCommand = "Select Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies ORDER BY Title";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var movie = new Movie();
                                //movie.Id = reader.GetInt32(0);
                                movie.Title = reader.GetString(1);
                                movie.Year = reader.GetInt32(2);
                                movie.Director = reader.GetString(3);
                                int genreNumber = reader.GetInt32(4);
                                if (genreNumber > 8 || genreNumber < 0)
                                {
                                    movie.Genre = "undefined";
                                }
                                else
                                {
                                    movie.Genre = genres[genreNumber];
                                }
                                if (!reader.IsDBNull(5))
                                {
                                    movie.RottenTomatoesScore = reader.GetInt32(5);
                                }
                                else
                                {
                                    movie.RottenTomatoesScore = 0;
                                }
                                if (!reader.IsDBNull(6))
                                {
                                    movie.TotalEarned = reader.GetDecimal(6);
                                }
                                else
                                {
                                    movie.TotalEarned = 0;
                                }
                                movies.Add(movie);
                            }
                        }
                        connection.Close();
                        MoviesListDataGridView.DataSource = movies;
                        MoviesListDataGridView.Columns[5].DefaultCellStyle.Format = "C2";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed. {ex.Message }");
            }
        }




        private void AddMovieToolStripMenuItem_Click(object sender, EventArgs e)
            {
                AddMovieForm form = new AddMovieForm();
                form.Show();
            }

            private void UpdateMovieToolStripMenuItem_Click(object sender, EventArgs e)
            {
                UpdateMovieForm form = new UpdateMovieForm();
                form.Show();
            }

            private void DeleteMovieToolStripMenuItem_Click(object sender, EventArgs e)
            {
                DeleteMovieForm form = new DeleteMovieForm();
                form.Show();
            }


    }
}


        