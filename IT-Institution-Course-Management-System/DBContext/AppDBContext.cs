using IT_Institution_Course_Management_System.Entities;
using IT_Institution_Course_Management_System.Entities.IT_Institution_Course_Management_System.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace IT_Institution_Course_Management_System.DBContext
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Student>()
           .HasOne(s => s.Address)
           .WithOne(a => a.Student)
           .HasForeignKey<Address>(a => a.StudentId)
          .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}
