using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Codefirstapcurd.Models
{
    public class ApplicationDbcontext:DbContext
    { public ApplicationDbcontext() : base("Data Source=DESKTOP-3571300\\" +
        "SQLEXPRESS;Initial Catalog=Emp;Integrated Security=True;Pooling=False") { }
        public DbSet<Employes> employes { get; set; }
    }
}