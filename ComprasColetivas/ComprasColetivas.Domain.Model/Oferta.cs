
using System;
using System.Collections.Generic;
namespace ComprasColetivas.Domain.Model
{
    public class Oferta
    {
        public TipoOferta tipoOferta;        
        public List<Cupom> cupons;
        public Endereco enderecoOferta;


        public bool OfertaValida() { throw new NotImplementedException(); }
    }
}