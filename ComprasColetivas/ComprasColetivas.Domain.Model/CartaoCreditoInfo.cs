using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasColetivas.Domain.Model
{
    public class CartaoCreditoInfo: Pagamento
    {
        public virtual BandeiraCartao Bandeira { get; set; }
        public virtual string Numero { get; set; }
        public virtual string NomeImpresso { get; set; }
        public virtual string Validade { get; set; }
        public virtual string CodigoSeguranca { get; set; }        
    }
}
