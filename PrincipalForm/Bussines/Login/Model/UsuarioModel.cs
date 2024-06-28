using System.ComponentModel.DataAnnotations.Schema;

namespace Negocio.Bussines.Login.Model
{
    [Table("t_Usuariosys")]
    public class UsuarioModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
