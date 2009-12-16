using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernateSimpleExample.App.Model;
using NHibernate;

namespace NHibernateSimpleExample.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private ISession session { get { return (HttpContext.ApplicationInstance as MvcApplication).NhSession; } }

        public ActionResult Index()
        {
            
            var persons = session.CreateCriteria<Person>().List<Person>();

            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View(persons);
        }

        public ActionResult About()
        {
            //var p = new Person() { FirstName = "Pontus", LastName = "Bremdahl" };

            //(HttpContext.ApplicationInstance as MvcApplication).NhSession.Save(p);

            return View();
        }

        public ActionResult Edit(int id)
        {
            return View(session.Get<Person>(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Person p)
        {
            var person = session.Load<Person>(id);

            person.FirstName = p.FirstName;
            person.LastName = p.LastName;

            return RedirectToAction("Index");
        }
    }
}
