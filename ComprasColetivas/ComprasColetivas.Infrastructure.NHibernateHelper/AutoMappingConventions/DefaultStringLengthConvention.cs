using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace ComprasColetivas.Infrastructure.NHibernateHelper
{
    public class DefaultStringLengthConvention : IPropertyConvention
    {
        public void Apply(IPropertyInstance instance)
        {
            if (instance.Name.ToUpper().Contains("SIGLA"))
                instance.Length(10);
            else if (instance.Name.ToUpper().Contains("CODIGO"))
                instance.Length(30);
            else if (instance.Name.ToUpper().Contains("NOME"))
                instance.Length(50);
            else if (instance.Name.ToUpper().Contains("DESCRICAO"))
                instance.Length(255);
            else if (instance.Name.ToUpper().Contains("DESCRICAOCURTA"))
                instance.Length(512);
            else if (instance.Name.ToUpper().Contains("OBSERVACAO"))
                instance.Length(1024);
            else if (instance.Name.ToUpper().Contains("DESCRICAOLONGA"))
                instance.Length(2048);
            else if (instance.Name.ToUpper().Contains("XML"))
                instance.Length(4096);
            else
                instance.Length(250);
        }
        
    }
}
