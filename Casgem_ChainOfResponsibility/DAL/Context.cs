using Microsoft.EntityFrameworkCore;

namespace Casgem_ChainOfResponsibility.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;initial Catalog=CasgemDbCoR;integrated Security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }

    }
}
