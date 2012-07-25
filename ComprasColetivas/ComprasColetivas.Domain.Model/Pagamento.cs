using System;
namespace ComprasColetivas.Domain.Model
{
    public abstract class Pagamento: ClasseBase
    {
        public virtual bool PagamentoAprovado { get; set; }
        public virtual DateTime DataAprovacao { get; set; }
    }
}