using System.Data.SqlClient;

namespace ToDo.Entity
{
    internal class DBConnector
    {
        private static DBConnector instance;
        private SqlConnection sqlConnection;

        private DBConnector()
        {
            sqlConnection = new SqlConnection("Server = localhost\\SQLEXPRESS;" +
                "Database = myBD;" +
                "Integrated Security = true;" +
                "TrustServerCertificate = true;");
        }

        public static DBConnector GetInstance()
        {
            if (instance == null) {
                instance = new DBConnector();
            }

            return instance;
        }

        public SqlConnection GetSqlConnection()
        {
            return sqlConnection;
        }
    }
}
