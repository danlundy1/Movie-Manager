/*Daniel Lundy
 * 05/03/2020
 * This is the code for the Update Movie Form.  Here you can search for a Title and the remaining fields
 * will complete if your title matches a title in the database.  Make a change and hit the update button.
 * Use File>Refresh List to see the change.  The Genre is stored as an integer but will show as the
 * string genre from the combobox.
 * 
 */

using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Movie;
using System.Collections.Generic;

namespace Movies
{
    public partial class UpdateMovieForm : Form
    {
        
        public UpdateMovieForm()
        {
            InitializeComponent();

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            updateMovieFormTitle.Text = "";
            updateMovieFormYear.Text = "";
            updateMovieFormDirector.Text = "";
            updateFormGenre.Text = "";
            updateMovieFormRottenTomatoesScore.Text = "";
            updateMovieFormTotalEarned.Text = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string[] genres = { "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
            string sqlCommand = "Select Id, Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned FROM Movies WHERE Title= @TITLE";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                    {
                        command.Parameters.AddWithValue("@TITLE", updateMovieFormTitle.Text);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                               
                                updateMovieFormYear.Text = reader["Year"].ToString();
                                updateMovieFormDirector.Text = reader["Director"].ToString();
                                
                                int genreNumber = reader.GetInt32(4);
                                updateFormGenre.Text = genres[genreNumber];
                                updateMovieFormRottenTomatoesScore.Text = reader["RottenTomatoesScore"].ToString();
                                updateMovieFormTotalEarned.Text = reader["TotalEarned"].ToString();
                            }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection failed. {ex.Message }");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            string[] genres = { "Animation", "Action", "Comedy", "Drama", "Horror", "Mystery", "Romance", "Science Fiction", "Western" };
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("UPDATE  Movies SET  Year = @Year, Director = @Director, Genre = @Genre, RottenTomatoesScore = @RottenTomatoesScore, TotalEarned = @TotalEarned WHERE Title = @Title", connection))
            {

                
                command.Parameters.AddWithValue("@Title", updateMovieFormTitle.Text);
                command.Parameters.AddWithValue("@Year", updateMovieFormYear.Text);
                command.Parameters.AddWithValue("@Director", updateMovieFormDirector.Text);
                object dbGenre = updateFormGenre.SelectedIndex;
                if (dbGenre == null)
                {
                    dbGenre = DBNull.Value;
                }

                command.Parameters.Add("Genre", SqlDbType.Int).Value = dbGenre;
                command.Parameters.AddWithValue("@RottenTomatoesScore", updateMovieFormRottenTomatoesScore.Text);
                command.Parameters.AddWithValue("@TotalEarned", updateMovieFormTotalEarned.Text);
                connection.Open();
                command.ExecuteNonQuery();
                DialogResult dr = MessageBox.Show(updateMovieFormTitle.Text + " has been updated successfully. Click OK", "Confirmation", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {

                }

            }


        }

   
    }
}







