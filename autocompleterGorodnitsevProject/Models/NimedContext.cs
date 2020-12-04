using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace autocompleterGorodnitsevProject.Models
{
    public class NimedContext : DbContext
    {
        public DbSet<Nimed> Nimeds { get; set; }
    }
}