using CRUD_Students_POO2.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Students_POO2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        
    }
}