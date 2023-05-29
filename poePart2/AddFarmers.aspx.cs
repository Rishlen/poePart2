using System;
using System.Configuration;
using poePart2;
using System.Data.SqlClient;
using System.Xml.Linq;

public partial class AddFarmer : System.Web.UI.Page
{
    protected void btnAddFarmer_Click(object sender, EventArgs e)
    {
        string txtName = null;
        string name = (string)txtName;
        string txtEmail = null;
        string email = (string)txtEmail;
        string txtPassword = null;
        string password = (string)txtPassword;
      

        if (InsertFarmer(name, email, password))
        {
            // Show success message or redirect to another page
        }
        else
        {
            // Show error message or redirect to a failure page
        }
    }

    private bool InsertFarmer(string name, string email, string password)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FarmersDBConnectionString"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Farmers (Name, Email, Password) VALUES (@Name, @Email, @Password)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}
