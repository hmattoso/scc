using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Application.APIContract.DataContract
{
    [DataContract]
    public class OfertaContract
    {
        public OfertaContract(Oferta item)
        {
            this.NomeFantasia = item.anunciante.NomeFantasia;
            this.tipoOferta = (int)item.tipoOferta == 1 ? "Serviço" : "Produto";
            this.Logradouro = item.enderecoOferta.Logradouro;
            this.Numero = item.enderecoOferta.Numero;
            this.Complemento = item.enderecoOferta.Complemento;
            this.CEP = item.enderecoOferta.CEP;
            this.Bairro = item.enderecoOferta.Bairro;
            this.Cidade = item.enderecoOferta.cidade.Nome;
            this.Inicio = item.Inicio;
            this.Fim = item.Fim;
            this.Titulo = item.Titulo;
            this.Descritivo = item.Descritivo;
            this.Imagem = item.Imagem;
            this.CnpjAnunciante = item.anunciante.CNPJ;
        }

        [DataMember]
        public string NomeFantasia { get; set; }
        [DataMember]
        public string CnpjAnunciante { get; set; }
        [DataMember]
        public string tipoOferta { get; set; }
        [DataMember]
        public string Logradouro { get; set; }
        [DataMember]
        public string Numero { get; set; }
        [DataMember]
        public string Complemento { get; set; }
        [DataMember]
        public string CEP { get; set; }
        [DataMember]
        public string Bairro { get; set; }
        [DataMember]
        public string Cidade { get; set; }
        [DataMember]
        public DateTime Inicio { get; set; }
        [DataMember]
        public DateTime Fim { get; set; }
        [DataMember]
        public string Titulo { get; set; }
        [DataMember]
        public string Descritivo { get; set; }
        [DataMember]
        public string Imagem { get; set; }
    }
}
