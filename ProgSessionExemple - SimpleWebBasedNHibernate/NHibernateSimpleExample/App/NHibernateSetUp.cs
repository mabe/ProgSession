using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Cfg;
using System.Reflection;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;

namespace NHibernateSimpleExample.App
{
    public static class NHibernateSetUp
    {
        public static NHibernate.Cfg.Configuration SetUp()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2005.ConnectionString(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Sample.mdf;Integrated Security=True;User Instance=True"))
                .Mappings(x => x.FluentMappings.AddFromAssembly(Assembly.Load("NHibernateSimpleExample")))
                .BuildConfiguration();
        }
    }
}
