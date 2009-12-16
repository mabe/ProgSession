using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using NHibernate;
using NHibernateSimpleExample.App;
using NHibernate.Tool.hbm2ddl;

namespace NHibernateSimpleExample
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static ISessionFactory NhSessionFactory { get; set; }
        public ISession NhSession { get; set; }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",                                              // Route name
                "{controller}/{action}/{id}",                           // URL with parameters
                new { controller = "Home", action = "Index", id = "" }  // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            RegisterRoutes(RouteTable.Routes);
        }

        static MvcApplication()
        {
            NhSessionFactory = NHibernateSetUp.SetUp().BuildSessionFactory();
        }

        public MvcApplication()
        {
            this.BeginRequest += (sender, e) => { this.NhSession = NhSessionFactory.OpenSession(); };
            this.EndRequest += (sender, e) => { this.NhSession.Flush(); this.NhSession.Dispose(); };
        }

        private void Generate()
        {
            new SchemaUpdate(NHibernateSetUp.SetUp()).Execute(true, true);
        }
    }
}