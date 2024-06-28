using Negocio.Bussines.Login.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Bussines.Login.Interfaces
{
    public interface ILoginDao
    {
        bool Autenticar(string username, string password, string tablename);
        bool VerificarExistenciaUsuario(string username);
        UsuarioModel ObterUsuario(string username);
    }
}
