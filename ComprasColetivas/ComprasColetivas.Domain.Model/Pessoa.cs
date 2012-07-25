namespace ComprasColetivas.Domain.Model
{
    public abstract class Pessoa : ClasseBase
    {
        public virtual string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }
        public virtual Contato Contato { get; set; }
        public virtual Login Login { get; set; }
    }
}