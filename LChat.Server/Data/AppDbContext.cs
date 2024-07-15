using LChat.Shared;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace LChat.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChatGroup>(entity =>
            {
                entity.HasOne(cg => cg.Leader)
                    .WithMany() // 或者指定反向导航属性，如果有的话  
                    .HasForeignKey(cg => cg.LeaderID);  
            });
        }

        public DbSet<ChatGroup> ChatGroups { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<GroupMember> GroupMembers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
    }

}
