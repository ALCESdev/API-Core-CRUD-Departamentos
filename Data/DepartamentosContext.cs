using API_CRUD_Departamentos.Models;
using Microsoft.EntityFrameworkCore;

namespace API_CRUD_Departamentos.Data
{
    public class DepartamentosContext : DbContext
    {
        public DepartamentosContext(DbContextOptions options) : base(options) { }
        public DbSet<Departamento> Departamentos { get; set; }
    }

}
