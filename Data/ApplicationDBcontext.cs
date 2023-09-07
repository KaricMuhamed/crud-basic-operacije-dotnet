using Microsoft.EntityFrameworkCore;
using prviProjekat_2_.Models;

namespace prviProjekat_2_.Data
{
    public class ApplicationDBcontext:DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }

        public DbSet<Expences> Expences { get; set; }
    }
}
