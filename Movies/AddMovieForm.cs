/*Daniel Lundy
 * 05/03/2020
 * This is the Add Movie controls.  Add a movie by Title, Year, Director, Genre, Rotten Tomatoes Score, and Total Earned.  
 * Complete the fields and click Add.  Refresh the list to see the new entry.
 * 
 */
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Movies
{
    public partial class AddMovieForm : Form
    {
        public AddMovieForm()
        {
            InitializeComponent();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            addMovieFormTitle.Text = "";
            addMovieFormYear.Text = "";
            addMovieFormDirector.Text = "";
            addMovieFormGenre.Text = "";
            addMovieFormRottenTomatoesScore.Text = "";
            addMovieFormTotalEarned.Text = "";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("INSERT INTO dbo.Movies (Title, Year, Director, Genre, RottenTomatoesScore, TotalEarned)"
                    + "Values (@Title, @Year, @Director, @Genre, @RottenTomatoesScore, @TotalEarned)", connection))
            {
                command.Parameters.Add("Title", SqlDbType.VarChar, 256).Value = addMovieFormTitle.Text;
                object dbDirector = addMovieFormDirector.Text;
                if(dbDirector == null)
                {
                    dbDirector = DBNull.Value;
                }
                command.Parameters.Add("Director", SqlDbType.VarChar, 256).Value = dbDirector;

                object dbYear = addMovieFormYear.Text;
                if(dbYear == null)
                {
                    dbYear = DBNull.Value;
                }
                command.Parameters.Add("Year", SqlDbType.VarChar, 256).Value = dbYear;

                object dbGenre = addMovieFormGenre.SelectedIndex;
                if(dbGenre == null)
                {
                    dbGenre = DBNull.Value;
                }
                
                command.Parameters.Add("Genre", SqlDbType.Int).Value = dbGenre;

                object dbRottenTomatoesScore = addMovieFormRottenTomatoesScore.Text;
                if(dbRottenTomatoesScore == null)
                {
                    dbRottenTomatoesScore = DBNull.Value;
                }
                command.Parameters.Add("RottenTomatoesScore", SqlDbType.VarChar, 256).Value = dbRottenTomatoesScore;

                object dbTotalEarned = addMovieFormTotalEarned.Text;
                if(dbTotalEarned == null)
                {
                    dbTotalEarned = DBNull.Value;
                }
                command.Parameters.Add("TotalEarned", SqlDbType.VarChar, 256).Value = dbTotalEarned;
                connection.Open();
                command.ExecuteNonQuery();

                DialogResult dr = MessageBox.Show(addMovieFormTitle.Text + " has been added successfully. Click OK", "Confirmation", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {

                }
            }
        }


        private void addMovieFormGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            addMovieFormGenre.SelectedItem = addMovieFormGenre.Text;
        }
    }
}
