using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Domain.Specification
{
    public class EspecificacaoOferta
    {
        public bool IsServico(Oferta oferta) { return oferta.tipoOferta == TipoOferta.SERVICO; }
        public bool IsProduto(Oferta oferta) { return oferta.tipoOferta == TipoOferta.PRODUTO; }
    }
}
