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
            ConnectionString = "your-connection-string-here"; // Substitua pela sua string de conexão real
        }
    }
}
