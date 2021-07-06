using BackendDemoProject.Core.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BackendDemoProject.Data
{
    public class AppDbContext : DbContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public AppDbContext(DbContextOptions<AppDbContext> options, IHttpContextAccessor httpContextAccessor = null)
            : base(options)
        {
            if (httpContextAccessor != null)
                _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<User> User { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleType> VehicleType { get; set; }
        public DbSet<Maintenance> Maintenance { get; set; }
        public DbSet<MaintenanceHistory> MaintenanceHistory { get; set; }
        public DbSet<PictureGroup> PictureGroup { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<ActionType> ActionType { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(new User
                {
                    ID = 1,
                    FirstName = "Admin",
                    LastName = "User",

                });

            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            AddDefaultValues();

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddDefaultValues();

            return base.SaveChangesAsync(cancellationToken);
        }

        private void AddDefaultValues()
        {
            var entries = ChangeTracker
              .Entries()
              .Where(e => e.Entity is BaseEntity && (
              e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                ((BaseEntity)entry.Entity).ModifyDate = DateTime.Now;
                ((BaseEntity)entry.Entity).ModifiedBy = Convert.ToInt32(_httpContextAccessor?.HttpContext?.User?.Identity.Name);

                if (entry.State == EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).CreatedDate = DateTime.Now;
                    ((BaseEntity)entry.Entity).CreatedBy = Convert.ToInt32(_httpContextAccessor?.HttpContext?.User?.Identity.Name);
                }
            }

        }
    }
}
