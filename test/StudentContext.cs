using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace test
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Direction> Directions { get; set; } = null!;        
        public StudentContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().Property(x => x.Name).HasMaxLength(50); 
        } Annotations in Student class look way cleaner tbh*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;
                                        Database = StudentDB;
                                        Trusted_Connection = true");
        }

    }
}
