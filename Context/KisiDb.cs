using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Context
{
    internal class KisiDb:DbContext
    {

        public DbSet<Kisi> Kisis { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data source=.;initial catalog=RehberDb;integrated security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Kisi>().Property(a => a.Ad).HasMaxLength(100);
            modelBuilder.Entity<Kisi>().Property(a => a.Soyad).HasMaxLength(100);
            modelBuilder.Entity<Kisi>().Property(a => a.Telefon).HasMaxLength(20);
            modelBuilder.Entity<Kisi>().HasData(
                new Kisi { KisiId = 1, Ad = "Ahmet", Soyad = "Yılmaz", Telefon = "(555) 333-22-22" },
                new Kisi { KisiId = 2, Ad = "Mehmet", Soyad = "Yılmaz", Telefon = "(555) 333-22-11" },
                new Kisi { KisiId = 3, Ad = "Elif", Soyad = "Güler", Telefon = "(555) 444-11-22" },
                new Kisi { KisiId = 4, Ad = "Hakan", Soyad = "Doruk", Telefon = "(555) 444-33-33" },
                new Kisi { KisiId = 5, Ad = "Erdem", Soyad = "Efendi", Telefon = "(444) 333-33-33" }
                );
        }
    }
}
