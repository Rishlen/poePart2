using System;
using poePart2;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;

public partial class AddProduct : System.Web.UI.Page
{
    protected void btnAddProduct_Click(object sender, EventArgs e)
    {
        int farmerId = GetLoggedInFarmerId(); 
        string txtName = null;
        string name = (string)txtName;
        string txtType = null;
        string type = (string)txtType;
        DateTime dateSupplied = DateTime.Now;

        if (InsertProduct(farmerId, name, type, dateSupplied))
        {
            // Show success message or redirect to another page
        }
        else
        {
            // Show error message or redirect to a failure page
        }
    }

    private int GetLoggedInFarmerId()
    {
        // get the logged-in farmer's ID 
        return 1; 
    }

    private bool InsertProduct(int farmerId, string name, string type, DateTime dateSupplied)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FarmersDBConnectionString"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO Products (FarmerID, Name, Type, DateSupplied) VALUES (@FarmerID, @Name, @Type, @DateSupplied)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FarmerID", farmerId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@DateSupplied", dateSupplied);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }
}

namespace poePart2
{
    class txtFarmerID
    {
        internal static object Text;
    }
}