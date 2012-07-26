using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Automapping;
using NHibernate;
using NHibernate.Cfg;
using System.IO;
using NHibernate.Tool.hbm2ddl;
using ComprasColetivas.Domain.Model;
using System.Threading;
using ComprasColetivas.Infrastructure.NHibernateHelper;

namespace ComprasColetivas.Infrastructure.NHibernateHelper
{

    public class DatabaseControl : IDisposable, IDatabaseControl
    {
        private static ISessionFactory factory;
        private static LocalDataStoreSlot mysessions;
        private static ISession session;

        public ISession Session
        {
            get { return session; }
        }

        private ITransaction transaction;
        private IInterceptor interceptor;
        private bool isSessionCreator;

        public bool IsSessionCreator
        {
            get { return this.isSessionCreator; }
        }

        public bool IsOpen
        {
            get { return DatabaseControl.GetIsOpen(Session); }
        }

        static DatabaseControl()
        {

            //log4net.Config.XmlConfigurator.Configure();

            AutoMappingConfiguration cfg = new AutoMappingConfiguration();

            System.Reflection.Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies().Where(w => w.FullName.Contains("ComprasColetivas.Domain.Model")).ToArray();

            factory = Fluently.Configure()

                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(Properties.Settings.Default.ConnectionStringSQLServer).ShowSql())                
                .Mappings(m =>
                {
                    m.AutoMappings.Add(AutoMap.Assemblies(cfg, assemblies).Conventions.Setup(c =>
                    {
                        c.Add<PrimaryKeyConvention>();
                        c.Add<CustomForeignKeyConvention>();
                        c.Add<DefaultStringLengthConvention>();
                        c.Add<TableConvention>();
                        c.Add<EnumMappingConvention>();

                    })
                                                                                                   );
                    m.AutoMappings.ToList()[0].IncludeBase<Pessoa>();
                    m.AutoMappings.ToList()[0].IncludeBase<Pagamento>();

                }).ExposeConfiguration(BuildSchema).BuildSessionFactory();

            mysessions = Thread.AllocateDataSlot();
        }

        public DatabaseControl()
        {
            this.isSessionCreator = true;
        }

        public DatabaseControl(IInterceptor interceptor)
            : this()
        {
            this.interceptor = interceptor;
        }

        public DatabaseControl(ISession psession, IInterceptor interceptor)
        {
            if (!DatabaseControl.GetIsOpen(session))
            {
                throw new Exception(String.Format("Uma {0} somente pode ser construido com uma sessão aberta.", this.GetType().ToString()));
            }

            session = psession;
            this.interceptor = interceptor;
        }

        public DatabaseControl(ISession psession)
        {
            if (!DatabaseControl.GetIsOpen(session))
            {
                throw new Exception(String.Format("A {0} somente pode ser construido com uma sessão aberta.", this.GetType().ToString()));
            }
            session = psession;
        }

        static public void TEnd()
        {
            Thread.SetData(mysessions, null);
        }
        static public DatabaseControl TPersister()
        {
            if (Thread.GetData(mysessions) == null)
                Thread.SetData(mysessions, new DatabaseControl());
            return Thread.GetData(mysessions) as DatabaseControl;
        }

        static public ISession TSession()
        {
            DatabaseControl r = TPersister();
            r.Open();
            return r.Session;
        }

        public bool Open()
        {
            if (!this.isSessionCreator)
            {
                throw new Exception("Um gateway que está compartilhando a sessão de outro gateway, não pode ser aberto diretamente.");
            }

            bool wasOpen = true;

            if (session == null || !session.IsOpen)
            {
                wasOpen = false;

                if (this.interceptor != null)
                {
                    session = factory.OpenSession(this.interceptor);
                }
                else
                {
                    session = factory.OpenSession();
                }
            }

            if (!this.Session.IsConnected)
            {
                wasOpen = false;
                this.Session.Reconnect();
            }

            this.Session.FlushMode = FlushMode.Auto;

            return wasOpen;
        }

        public void Close()
        {
            if (!this.isSessionCreator)
            {
                throw new Exception("Um gateway que está compartilhando a sessão de outro gateway, não pode ser fechado diretamente.");
            }

            if (session == null)
            {
                return;
            }

            if (session.IsConnected)
            {
                session.Disconnect();
            }

            if (session.IsOpen)
            {
                session.Close();
            }
        }

        public void BeginTransaction()
        {
            if (!this.isSessionCreator)
            {
                throw new Exception("Um gateway que está compartilhando a sessão de outro gateway, não pode iniciar uma transação diretamente.");
            }

            if (!this.IsOpen)
            {
                throw new Exception("A conexão deve ser aberta antes de iniciar uma transação.");
            }

            if (this.transaction == null)
            {
                this.transaction = session.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            }

            this.Session.FlushMode = FlushMode.Never;

        }

        public void CommitTransaction()
        {
            if (!this.isSessionCreator)
            {
                throw new Exception("Um gateway que está compartilhando a sessão de outro gateway, não pode dar commit numa transação diretamente");
            }

            if (!this.IsOpen)
            {
                throw new Exception("A conexão deve ser aberta antes de dar commit numa transação.");
            }

            if (this.transaction == null)
            {
                throw new Exception("A conexão deve possuir uma transação aberta para dar commit.");
            }

            this.Session.FlushMode = FlushMode.Auto;

            this.transaction.Commit();

            this.Session.Flush();

            this.transaction = null;

        }

        public void Rollback()
        {
            if (!this.isSessionCreator)
            {
                throw new Exception("Um gateway que está compartilhando a sessão de outro gateway, não pode dar rollback diretamente");
            }
            if (!this.IsOpen)
            {
                throw new Exception("A conexão deve estar aberta antes de ser processado um rollback.");
            }
            if (this.transaction != null)
            {
                this.transaction.Rollback();
                this.transaction = null;
            }

            this.Session.FlushMode = FlushMode.Auto;

        }

        protected static bool GetIsOpen(ISession session)
        {
            if (session == null || !session.IsOpen)
            {
                return false;
            }

            if (!session.IsConnected)
            {
                return false;
            }

            return true;
        }

        public static bool IsPersisted(object obj, object id)
        {

            try
            {
                object ot = typeof(Type);
                Type t = (obj.GetType() == ot.GetType()) ? (Type)obj : obj.GetType();
                object o = session.Load(t, id);
                string s = o.ToString();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

            //SQL Server está gerando lock com esta instrução.
            //using (ISession session = DatabaseControl.factory.OpenSession())
            //{
            //    try
            //    {
            //        object ot = typeof(Type);
            //        Type t = (obj.GetType() == ot.GetType()) ? (Type)obj : obj.GetType();
            //        object o = session.Load(t, id);
            //        string s = o.ToString();
            //        return true;
            //    }
            //    catch (Exception ex)
            //    {
            //        return false;
            //    }

            //}

        }

        public void Dispose(bool isDisposing)
        {
            if (isDisposing)
            {
                this.Close();

                if (this.transaction != null)
                {
                    this.transaction.Dispose();
                    this.transaction = null;
                }

                if (session != null)
                {
                    session.Dispose();
                    session = null;
                }

                this.interceptor = null;

                if (Thread.GetData(mysessions) == this)
                    Thread.SetData(mysessions, null);
            }
        }

        private static void BuildSchema(Configuration config)
        {

            new SchemaUpdate(config).Execute(true, true);

            new SchemaExport(config).Create(true, true);

            new SchemaValidator(config).Validate();

        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~DatabaseControl()
        {
            Dispose(false);
        }
    }
}

