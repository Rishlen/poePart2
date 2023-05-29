using poePart2;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

public partial class ViewProducts : System.Web.UI.Page
{
    protected void btnFilterProducts_Click(object sender, EventArgs e, object gvProducts)
    {
        int farmerId = Convert.ToInt32(txtFarmerID.Text);
        DateTime startDate = Convert.ToDateTime(txtStartDate.Text);
        DateTime endDate = Convert.ToDateTime(txtEndDate.Text).AddDays(1); // Add one day to include the end date

        DataTable dtProducts = GetFilteredProducts(farmerId, startDate, endDate);
      
    }

    private DataTable GetFilteredProducts(int farmerId, DateTime startDate, DateTime endDate)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["FarmersDBConnectionString"].ConnectionString;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT Name, Type, DateSupplied FROM Products WHERE FarmerID = @FarmerID AND DateSupplied >= @StartDate AND DateSupplied < @EndDate";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@FarmerID", farmerId);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataTable dtProducts = new DataTable();
                    adapter.Fill(dtProducts);
                    return dtProducts;
                }
            }
        }
    }

    private class txtStartDate
    {
        internal static DateTime Text;
    }
}

internal class txtEndDate
{
    internal static DateTime Text;
}