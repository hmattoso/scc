
using System;
using System.Collections.Generic;
namespace ComprasColetivas.Domain.Model
{
    public class Oferta : ClasseBase
    {
        public virtual Anunciante anunciante { get; set; }
        public virtual TipoOferta tipoOferta { get; set; }
        public virtual Endereco enderecoOferta { get; set; }
        public virtual DateTime Inicio { get; set; }
        public virtual DateTime Fim { get; set; }
        public virtual string Titulo { get; set; }
        public virtual string Descritivo { get; set; }
        public virtual string Imagem { get; set; }

        public virtual bool IsVigente()
        {
            return (this.Fim >= DateTime.Now);
        }

        public Oferta() { }

        public Oferta(Anunciante anunciante, string tipoOferta, Endereco enderecoOferta, DateTime inicio, DateTime fim, string tituloOferta, string descritivoOferta, string imagem)
        {
            this.anunciante = anunciante;
            this.tipoOferta = tipoOferta == "Serviço" ? TipoOferta.SERVICO : TipoOferta.PRODUTO;
            this.enderecoOferta = enderecoOferta;
            this.Inicio = inicio;
            this.Fim = fim;
            this.Titulo = tituloOferta;
            this.Descritivo = descritivoOferta;
            this.Imagem = imagem;
        }
    }
}