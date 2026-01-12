using AuthMicroservice.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuthMicroservice.Infrastructure.Data
{

    public class AuthDbContext(DbContextOptions<AuthDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<RefreshToken> RefreshTokens => Set<RefreshToken>();
        public DbSet<Role> Roles => Set<Role>();
        public DbSet<UserRole> UserRoles => Set<UserRole>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<UserLogin> UserLogins => Set<UserLogin>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.HasIndex(u => u.Email).IsUnique();
                entity.Property(u => u.Email).IsRequired().HasMaxLength(255);
                entity.Property(u => u.PasswordHash).HasMaxLength(255);
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.HasKey(rt => rt.Id);
                entity.HasIndex(rt => rt.Token).IsUnique();
                entity.HasIndex(rt => rt.UserId);
                entity.Property(rt => rt.Token).IsRequired().HasMaxLength(255);
                entity.HasOne(rt => rt.User)
                    .WithMany(u => u.RefreshTokens)
                    .HasForeignKey(rt => rt.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(r => r.Id);
                entity.HasIndex(r => r.Name).IsUnique();
                entity.Property(r => r.Name).IsRequired().HasMaxLength(100);
                entity.Property(r => r.Description).HasMaxLength(500);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(ur => new { ur.UserId, ur.RoleId});
                entity.HasOne(ur => ur.User)
                    .WithMany(u => u.UserRoles)
                    .HasForeignKey(ur => ur.UserId)
                    .OnDelete(DeleteBehavior.Cascade);
                entity.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(c => c.ClientId);
                entity.Property(c => c.ClientId).HasMaxLength(100);
                entity.Property(c => c.ClientName).HasMaxLength(200);
                entity.Property(c => c.ClientSecretHash).HasMaxLength(255);
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.HasKey(ul => ul.Id);
                entity.HasIndex(ul => ul.UserId); 
                entity.HasIndex(ul => ul.Email);
                entity.HasIndex(ul => ul.Timestamp);
                entity.Property(ul => ul.Email).IsRequired().HasMaxLength(255);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
