
namespace ComprasColetivas.Domain.Model
{

    public class Login
    {
        public virtual string Usuario { get; set; }
        public virtual string Senha { get; set; }
        public virtual bool Bloqueado { get; set; }
    }
}