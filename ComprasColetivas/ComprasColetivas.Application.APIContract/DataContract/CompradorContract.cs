using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ComprasColetivas.Application.APIContract.DataContract
{
    [DataContract]
    public class CompradorContract
    {
        [DataMember]
        public  DateTime Nascimento { get; set; }
        [DataMember]
        public  string CPF { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public  string RG { get; set; }
        [DataMember]
        public  string OrgaoEmissor { get; set; }
        [DataMember]
        public  string FiliacaoPai { get; set; }
        [DataMember]
        public  string FiliacaoMae { get; set; }
        [DataMember]
        public  bool RecebeEmailOferta { get; set; }
    }
}
