using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;
//tinfo200:[2020-03-13-seguya-dykstra2]
namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        //tinfo200:[2020-03-13-seguya-dykstra2]:Base constructor call.
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        //tinfo200:[2020-03-13-seguya-dykstra2]: We are telling the database that it has to take in a course, enrollments and students.
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        //tinfo200:[2020-03-13-seguya-dykstra2]: Telling the database what names to use in the table
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}