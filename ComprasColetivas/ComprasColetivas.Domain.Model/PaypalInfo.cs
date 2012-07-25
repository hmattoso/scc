using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasColetivas.Domain.Model
{
    public class PaypalInfo: Pagamento
    {
        public virtual string TransactionID { get; set; }
    }
}
