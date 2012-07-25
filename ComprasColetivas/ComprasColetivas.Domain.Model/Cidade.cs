using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComprasColetivas.Domain.Model
{
    public class Cidade: ClasseBase
    {
        public virtual string Nome { get; set; }
        public virtual string Sigla { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
