using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSO_PlakDukkani.Concrets
{
    public class PlakDukkaniContext : DbContext
    {
        public DbSet<Modul> Moduls { get; set; }
        public DbSet<Album> Albumler { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDb;Database=PlakDukkaniDb");
        }

    }
}
