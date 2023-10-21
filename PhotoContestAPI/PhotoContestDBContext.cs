using Microsoft.EntityFrameworkCore;
using PhotoContestAPI.Model;

namespace PhotoContestAPI
{
    public class PhotoContestDBContext : DbContext
    {
        public PhotoContestDBContext()
        {
        }
        public PhotoContestDBContext(DbContextOptions<PhotoContestDBContext> options) : base(options)
        {
        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<AdminModel> Admins { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }

    }
}
