using MeuSite2.Models;
using Microsoft.EntityFrameworkCore;

public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<CustomerMovements> customerMovements { get; set; }
    }
