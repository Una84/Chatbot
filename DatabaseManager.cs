using MySql.Data.MySqlClient;

namespace CybersecurityAwarenessBot
{
    public class DatabaseManager
    {
        private string connectionString =
            "server=localhost;database=CyberBot;uid=root;pwd=;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
