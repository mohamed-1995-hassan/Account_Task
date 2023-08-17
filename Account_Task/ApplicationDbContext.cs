using Account_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace Account_Task
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options){ }
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
