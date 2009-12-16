using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernateSimpleExample.App.Model;
using FluentNHibernate.Mapping;

namespace NHibernateSimpleExample.App.Data.Mapping
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id).GeneratedBy.HiLo("100").UnsavedValue(default(int));
            Map(x => x.FirstName);
            Map(x => x.LastName);
        }
    }
}
