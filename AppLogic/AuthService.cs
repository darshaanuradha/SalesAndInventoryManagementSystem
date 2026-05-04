using Microsoft.Data.SqlClient;

namespace IMS.AppLogic
{
    internal class AuthService
    {
        public bool ValidateUser(string username, string password)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection()) 
            {
                string query = "SELECT COUNT(1) FROM Users WHERE Username = @user AND PasswordHash = @pass";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password); // In a real application, you should hash the password before comparing
                    try
                    {
                        conn.Open();
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count == 1; // Returns true if user exists
                    }
                    catch (Exception)
                    {
                        // Log error here if needed
                        return false;
                    }
                }
            }
            
        }
    }
}
