using Microsoft.Data.SqlClient;

namespace Infraestrutura.Factory
{
    public sealed class DbConnectionFactory
    {
        private static readonly Lazy<DbConnectionFactory> instance = new Lazy<DbConnectionFactory>(() => new DbConnectionFactory());

        public static DbConnectionFactory Instance => instance.Value;

        private DbConnectionFactory()
        {
        }

        public SqlConnection CreateConnection()
        {
            string connectionString = ConnectionManager.Instance.ConnectionString;
            return new SqlConnection(connectionString);
        }
    }
}
