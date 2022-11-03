using Microsoft.EntityFrameworkCore;
using mvcfull_operation.Models;

namespace mvcfull_operation.Data
{
    public class MvcDbContext:DbContext
    {
        public MvcDbContext()
        {
        }

        public MvcDbContext(DbContextOptions<MvcDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Signup> Signups { get; set; }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Usermanagement> Usermanagements { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public virtual DbSet<EmployeeLogin> EmployeeLogin { get; set; }
        public DbSet<mvcfull_operation.Models.MvcScafoldModel> MvcScafoldModel { get; set; }
    }


}
