
using System;
namespace ComprasColetivas.Domain.Model
{

    public class Cupom: ClasseBase
    {
        public virtual Oferta oferta { get; set; }
        public virtual Comprador comprador { get; set; }
        public virtual DateTime Emissao { get; set; }
        public virtual DateTime Validade { get; set; }
        public virtual bool Utilizado { get; set; }
        public virtual Pagamento Pagamento { get; set; }
       
        public bool IsValido()
        {
            return (this.Validade >= DateTime.Now);
        }
    }

}