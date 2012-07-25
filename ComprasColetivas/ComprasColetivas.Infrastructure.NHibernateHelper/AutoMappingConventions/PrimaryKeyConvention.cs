using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;

namespace ComprasColetivas.Infrastructure.NHibernateHelper
{
    public class PrimaryKeyConvention: IIdConvention
    {
        public void Apply(IIdentityInstance instance)
        {
            instance.Column("fk_"+ instance.EntityType.Name);
            instance.GeneratedBy.Guid();
        }
    }
}
