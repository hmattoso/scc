using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ComprasColetivas.Application.APIContract.DataContract
{
    [DataContract]
    public class OfertaContract
    {
        [DataMember]
        public string NomeFantasia { get; set; }
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
