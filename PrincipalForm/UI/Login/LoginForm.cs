using Autofac;
using Negocio.Bussines.Login.Interfaces;
using Sistema.Infraestrutura.Dependency_Injection;
using Sistema.UI.Dashboard;

namespace PrincipalForm
{
    public partial class LoginForm : Form
    {
        private ILoginBis loginBis;
        public LoginForm()
        {
            InitializeComponent();
            loginBis = DInjector.Container.Resolve<ILoginBis>();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var autenticacao = loginBis.SelectWhere($"Login = {tbLogin}");
            if (autenticacao.Count > 0)
            {
                InicioBaseForm inicioBaseForm = new InicioBaseForm();
                inicioBaseForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erro");
            }
        }
    }
}
