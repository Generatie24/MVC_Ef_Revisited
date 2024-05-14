using Microsoft.EntityFrameworkCore;
using MVC_Ef_Revisited.Models;

namespace MVC_Ef_Revisited.Data
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options ) :base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}
