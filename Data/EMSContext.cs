using Microsoft.EntityFrameworkCore;
using ContosoPets.Api.Models;
using CoreEMS.Models;

namespace Core.Data
{
    public class EMSContext : DbContext
    {
        public EMSContext(DbContextOptions<EMSContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(SeedData.departments);
            modelBuilder.Entity<Semester>().HasData(SeedData.semesters);
            modelBuilder.Entity<Section>().HasData(SeedData.sections);
            modelBuilder.Entity<Guardian>().HasData(SeedData.guardians);
            modelBuilder.Entity<Student>().HasData(SeedData.students);

            modelBuilder.Entity<Semester>()
                .HasOne(p => p.Department)
                .WithMany(b => b.Semesters);
            
        }
    }
}