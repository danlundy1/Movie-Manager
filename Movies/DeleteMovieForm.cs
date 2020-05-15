/*Daniel Lundy
 * 05/03/2020
 * This is the delete movie form.  This form uses the find logic and Delete SQL command to delete a movie from the database.
 * The user is prompted to confirm before deleting.  Select refresh list to see the change.
 * 
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Movies;
namespace Movies
{
    public partial class DeleteMovieForm : Form
    {
        public DeleteMovieForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            deleteMovieFormTitle.Text = "";
            deleteMovieFormYear.Text = "";
            deleteMovieFormDirector.Text = "";
            deleteMovieFormGenre.Text = "";
            deleteMovieFormRottenTomatoesScore.Text = "";
            deleteMovieFormTotalEarned.Text = "";
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to delete " + deleteMovieFormTitle.Text + "?", "Confirmation", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
                try { 
                using (SqlConnection connection = new SqlConnection(connectionString))

                using (SqlCommand command = new SqlCommand("DELETE FROM dbo.Movies WHERE Title = @Title", connection))

                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Title", deleteMovieFormTitle.Text);
                    command.ExecuteNonQuery();

                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database connection failed. {ex.Message }");
                }
            }
            else if (DialogResult == DialogResult.No)
            {

            }
        }


        private void deleteMovieFormGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            deleteMovieFormGenre.SelectedItem = deleteMovieFormGenre.Text;
        }

        private void DeleteFormFindButton_Click(object sender, EventArgs e)
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
                        command.Parameters.AddWithValue("@TITLE", deleteMovieFormTitle.Text);
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                            while (reader.Read())
                            {
                                deleteMovieFormYear.Text = reader["Year"].ToString();
                                deleteMovieFormDirector.Text = reader["Director"].ToString();
                                int genreNumber = reader.GetInt32(4);

                                deleteMovieFormGenre.Text = genres[genreNumber];
                                deleteMovieFormRottenTomatoesScore.Text = reader["RottenTomatoesScore"].ToString();
                                deleteMovieFormTotalEarned.Text = reader["TotalEarned"].ToString();
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
    }
}
           
    


        
