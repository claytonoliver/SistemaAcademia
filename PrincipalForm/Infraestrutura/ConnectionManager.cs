using System;

namespace Infraestrutura
{
    public sealed class ConnectionManager
    {
        private static readonly Lazy<ConnectionManager> instance = new Lazy<ConnectionManager>(() => new ConnectionManager());

        public static ConnectionManager Instance => instance.Value;

        public string ConnectionString { get; private set; }

        private ConnectionManager()
        {
            ConnectionString = "Data Source=DESKTOP-ENA9A3U\\SQLEXPRESS;Initial Catalog=Academia;Integrated Security=True;Trust Server Certificate=True";
        }
    }
}
