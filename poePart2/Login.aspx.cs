using System;
using poePart2;
using System.Configuration;
using System.Data.SqlClient;

public partial class Login : System.Web.UI.Page
{
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        string txtEmail = null;
        string email = (string)txtEmail;
        string txtPassword = null;
        string password = (string)txtPassword;
        
        if (ValidateUser(email, password))
        {
            // Determine the user role based on the email or any other logic
            string userRole = DetermineUserRole(email);

            if (userRole == "farmer")
                Response.Redirect("AddProduct.aspx");
            else if (userRole == "employee")
                Response.Redirect("ViewProducts.aspx");
        }
        else
        {
            // Show error message 
        }
    }

    private bool ValidateUser(string email, string password)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FarmersDBConnectionString"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT COUNT(*) FROM Farmers WHERE Email = @Email AND Password = @Password";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
            connection.Close();
        }
    }

    private string DetermineUserRole(string email)
    {
        return "employee";
    }
}

