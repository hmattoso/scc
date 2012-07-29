using System;
using System.Collections.Generic;

namespace ComprasColetivas.Domain.Model
{
    public class Comprador : Pessoa
    {
        public virtual DateTime Nascimento { get; set; }
        public virtual string CPF { get; set; }
        public virtual string RG { get; set; }
        public virtual string OrgaoEmissor { get; set; }
        public virtual string FiliacaoPai { get; set; }
        public virtual string FiliacaoMae { get; set; }
        public virtual bool RecebeEmailOferta { get; set; }


        public bool IsAniversario()
        {
            return (Nascimento.Day == DateTime.Now.Day);
        }
    }
}
