using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace NHibernateSimpleExample.App.Model
{
    public class Person
    {
        [ScaffoldColumn(false)]
        public virtual int Id { get; set; }

        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}
