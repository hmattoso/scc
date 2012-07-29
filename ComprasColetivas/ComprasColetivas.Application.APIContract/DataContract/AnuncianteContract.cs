using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ComprasColetivas.Application.APIContract.DataContract
{
    [DataContract]
    public class AnuncianteContract
    {
        [DataMember]
        public string CNPJ { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public string NomeFantasia { get; set; }
        [DataMember]
        public string InscricaoMunicipal { get; set; }
        [DataMember]
        public string InscricaoEstadual { get; set; }
        [DataMember]
        public string WebSite { get; set; }
    }
}
