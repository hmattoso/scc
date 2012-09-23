using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Application.APIContract.DataContract
{
    [DataContract]
    public class CupomContract
    {
        public CupomContract(Cupom item)
        {
            this.TituloOferta = item.oferta.Titulo;
            this.DescritivoOferta = item.oferta.Descritivo;
            this.InicioOferta = item.oferta.Inicio;
            this.FimOferta = item.oferta.Fim;
            this.NomeComprador = item.comprador.Nome;
            this.CPFComprador = item.comprador.CPF;
            this.Emissao = item.Emissao;
            this.Validade = item.Validade;
            this.Utilizado = item.Utilizado;
            this.PagamentoAprovado = item.Pagamento.PagamentoAprovado;
            this.DataAprovacaoPagamento = item.Pagamento.DataAprovacao;
        }

        [DataMember]
        public string TituloOferta { get; set; }
        [DataMember]
        public string DescritivoOferta { get; set; }
        [DataMember]
        public DateTime InicioOferta { get; set; }
        [DataMember]
        public DateTime FimOferta { get; set; }
        [DataMember]
        public string NomeComprador { get; set; }
        [DataMember]
        public string CPFComprador { get; set; }
        [DataMember]
        public DateTime Emissao { get; set; }
        [DataMember]
        public DateTime Validade { get; set; }
        [DataMember]
        public bool Utilizado { get; set; }
        [DataMember]
        public bool PagamentoAprovado { get; set; }
        [DataMember]
        public DateTime DataAprovacaoPagamento { get; set; }

    }
}
