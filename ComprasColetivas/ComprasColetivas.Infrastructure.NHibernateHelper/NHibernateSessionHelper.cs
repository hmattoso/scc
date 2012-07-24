using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;

namespace ComprasColetivas.Infrastructure.NHibernateHelper
{
    public class NHibernateSessionHelper
    {
        private static ISessionFactory sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get { if (sessionFactory == null) CreateSessionFactory(); return sessionFactory; }
        }

        private static void CreateSessionFactory()
        {
            sessionFactory = Fluently.Configure()
                .Database(MsSqlCeConfiguration.Standard.ConnectionString(@"").ShowSql())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();
        }
    }
}
