using CoreMigration.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMigration
{
    public class ConnectionDbClass : DbContext
    {
        public ConnectionDbClass(DbContextOptions<ConnectionDbClass> options) : base(options)
        {

        }

        public DbSet<Activite> activites { get; set; }
        public DbSet<admin> admins { get; set; }
        public DbSet<association> associations { get; set; }
        public DbSet<BDE> BDEs { get; set; }
        public DbSet<club> clubs { get; set; }
        public DbSet<filiere> filieres { get; set; }
        public DbSet<gallerie> galleries { get; set; }
        public DbSet<laureat> laureats { get; set; }
        public DbSet<membre_BDE> membre_BDE { get; set; }
        public DbSet<Responsable> Responsables { get; set; }
    }
}
