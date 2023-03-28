using Microsoft.EntityFrameworkCore;
using P22CV.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P22CV.Context
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=LAPTOP-1TJ137V4;Database=P22CV;Trusted_Connection=True;");
        }

        public DbSet<Actores> Actores { get; set; }
        public DbSet<Directores> Directores { get; set; }
        public DbSet<Peliculas> Peliculas { get; set; }
        public DbSet<Estudios> Estudios { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
