using Microsoft.EntityFrameworkCore;
using CRUDNATIVO703.Models;

namespace CRUDNATIVO703.Data
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
       
        
        {


        }
        public DbSet<Models.Libro> Libros { get; set; } // DbSet para la entidad Libro
        public DbSet<CRUDNATIVO703.Models.Cliente> Cliente { get; set; } = default!;

    }
   
}
