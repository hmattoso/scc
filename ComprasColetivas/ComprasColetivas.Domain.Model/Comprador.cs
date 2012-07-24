using System;
using System.Collections.Generic;

namespace ComprasColetivas.Domain.Model
{
    public class Comprador : Pessoa
    {
        public List<Cupom> cupons;

        public DateTime CalcularDataAniversario() { throw new NotImplementedException(); }

        public bool RecebeEmailOferta() { throw new NotImplementedException(); }
    }
}
