using CrudApp.WebUI.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.WebUI.Context
{
    public class CrudAppContext: DbContext
    {
        //public CrudAppContext(DbContextOptions<CrudAppContext> dbContextOptions): base(dbContextOptions)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-NOOAEV8\SQLEXPRESS;Database=CrudAppDb;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
