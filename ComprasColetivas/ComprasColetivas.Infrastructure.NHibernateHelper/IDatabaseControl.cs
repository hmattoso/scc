using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;

namespace ComprasColetivas.Infrastructure.NHibernateHelper
{
    public interface IDatabaseControl
    {
        void BeginTransaction();
        void CommitTransaction();
        bool IsOpen { get; }
        void Rollback();
        ISession Session { get; }
    }
}
