using EduPlatform.Domain.Common;
using EduPlatform.Domain.Entities;
using EduPlatform.Persistence.EF.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduPlatform.Persistence.EF
{
    public class EduPlatformContext : DbContext
    {
        public EduPlatformContext(DbContextOptions<EduPlatformContext> options)
            :base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Webinar> Webinars { get; set; }
        public DbSet<Post> Posts { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    default:
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EduPlatformContext).Assembly);
            modelBuilder.SeedPost();
            modelBuilder.SeedWebinar();
            modelBuilder.SeedCategory();
        }



    }
}
