using Microsoft.EntityFrameworkCore;
using SchoolSystem.Domain;


namespace SchoolSystem.Infrastructure.Data
{
    public class SchoolSystemDbContext : DbContext
    {
        public SchoolSystemDbContext()
        {
            
        }

        public SchoolSystemDbContext(DbContextOptions<SchoolSystemDbContext> options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<DepartmentSubject> DepartmentSubjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
    }
}
