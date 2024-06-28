using Infraestrutura.Generic_DAL;
using Negocio.Bussines.Login.DAL;
using Negocio.Bussines.Login.Interfaces;
using Negocio.Bussines.Login.Model;

namespace Negocio.Bussines.Login
{
    public class LoginBis: ILoginBis
    {
        private readonly GenericDAO<UsuarioModel> _genericDao;
        private readonly LoginDao _loginDao;

        public LoginBis(GenericDAO<UsuarioModel> genericDao, LoginDao loginDao)
        {
            _genericDao = genericDao;
            _loginDao = loginDao;
        }

        // Exemplo de método usando o GenericDAO
        public List<UsuarioModel> SelectWhere(string condicao)
        {
            return _genericDao.SelectWhere(condicao);
        }

        // Exemplo de método usando o LoginDao
        public bool Autenticar(string username, string password, string tablename)
        {
            return _loginDao.Autenticar(username, password, tablename);
        }
    }
}
