using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using FluentNHibernate.Conventions;

namespace ComprasColetivas.Infrastructure.NHibernateHelper
{
    public class CustomForeignKeyConvention: ForeignKeyConvention
    {
        protected override string GetKeyName(FluentNHibernate.Member property, Type type)
        {
            if (property == null)
                return "fk_" + type.Name;

            return "fk_" + property.Name;
        }
        
    }
}
