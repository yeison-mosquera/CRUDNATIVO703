using Microsoft.EntityFrameworkCore;

namespace CRUDNATIVO703.Data
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
       
        
        {


        }
        public DbSet<Models.Libro> Libros { get; set; } // DbSet para la entidad Libro

    }
   
}
