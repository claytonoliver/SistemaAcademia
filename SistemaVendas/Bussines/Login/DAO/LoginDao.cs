using Infraestrutura.Factory;
using Microsoft.Data.SqlClient;
using Negocio.Bussines.Login.Interfaces;
using Negocio.Bussines.Login.Model;
using System.Data;

namespace Negocio.Bussines.Login.DAL
{
    public class LoginDao : ILoginDao
    {
        private readonly DbConnectionFactory _dbConnectionFactory;

        public LoginDao(DbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public bool Autenticar(string username, string password)
        {
            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Usuarios WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public bool VerificarExistenciaUsuario(string username)
        {
            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Usuarios WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public UsuarioModel ObterUsuario(string username)
        {
            using (var connection = _dbConnectionFactory.CreateConnection())
            {
                connection.Open();

                string query = "SELECT Username, Password FROM Usuarios WHERE Username = @Username";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new UsuarioModel
                    {
                        Username = reader["Username"].ToString(),
                        Password = reader["Password"].ToString()
                    };
                }
                return null;
            }
        }
    }
}
