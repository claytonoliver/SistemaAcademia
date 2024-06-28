using Infraestrutura.Generic_DAL;
using Negocio.Bussines.Login.DAL;
using Negocio.Bussines.Login.Model;

namespace Negocio.Bussines.Login
{
    public class LoginBis
    {
        private readonly GenericDAO<UsuarioModel> _genericDao;
        private readonly LoginDao _loginDao;

        public LoginBis(GenericDAO<UsuarioModel> genericDao, LoginDao loginDao)
        {
            _genericDao = genericDao;
            _loginDao = loginDao;
        }

        // Exemplo de método usando o GenericDAO
        public UsuarioModel GetById(int id)
        {
            return _genericDao.GetById(id);
        }

        // Exemplo de método usando o LoginDao
        public bool Autenticar(string username, string password)
        {
            return _loginDao.Autenticar(username, password);
        }
    }
}
