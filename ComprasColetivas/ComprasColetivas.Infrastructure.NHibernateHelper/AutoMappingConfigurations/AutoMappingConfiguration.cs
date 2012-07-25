using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Automapping;
using FluentNHibernate;
using ComprasColetivas.Domain.Model;

namespace ComprasColetivas.Infrastructure.NHibernateHelper
{
    public class AutoMappingConfiguration : DefaultAutomappingConfiguration
    {
       
        public override bool ShouldMap(Type type)
        {
            if (type.IsEnum) return false;

            return type.Namespace.Contains("ComprasColetivas.Domain.Model"); ;

        }

        public override bool IsId(Member member)
        {
            
            return member.Name == "Id";
      
        }

        public override bool IsComponent(Type type)
        {
            return type == typeof(Endereco) || type == typeof(Contato) || type == typeof(Login);
        }

        public override string GetComponentColumnPrefix(Member member)
        {
            return member.PropertyType.Name + "_";
        }                   

    }
}
