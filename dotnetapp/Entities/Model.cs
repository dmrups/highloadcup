using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace dotnetapp.Entities
{
    public class Model : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Visit> Visits { get; set; }

        public Model() { }

        public Model(DbContextOptions<Model> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=:memory:");
            }
        }
    }
}