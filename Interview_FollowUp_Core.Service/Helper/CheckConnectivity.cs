using System.Data.SqlClient;

namespace Interview_FollowUp_Core.Service.Helper
{
    public class CheckConnectivity
    {
        public bool CheckDatabaseConnection(string connectionString)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
