using project_SWD.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Transactions;
using project_SWD.Controllers;

namespace project_SWD.Data
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options) { }
        public DbSet<product> products { get; set; }
        public DbSet<category> categories { get; set; }
        public DbSet<seller> sellers { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<shopping_order> shopping_Orders { get; set; }
        public DbSet<payment> payments { get; set; }
        public DbSet<order_context> order_context { get; set; }
        public DbSet<comment> comments { get; set; }
       

    }
}
