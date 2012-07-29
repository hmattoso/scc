using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ComprasColetivas.Application.APIContract.DataContract
{
    [DataContract]
    public class CupomContract
    {
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
