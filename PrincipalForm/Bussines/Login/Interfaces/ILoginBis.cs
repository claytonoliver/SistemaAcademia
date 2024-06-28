using Negocio.Bussines.Login.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Bussines.Login.Interfaces
{
    public interface ILoginBis
    {
        List<UsuarioModel> SelectWhere(string condicao);
        bool Autenticar(string username, string password, string tablename);
    }
}
