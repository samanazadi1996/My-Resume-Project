using Infrastructure.DomainModel.Common;
using Infrastructure.DomainModel.Identity;
using Infrastructure.Persistence.Extentions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var entitiesAssembly = typeof(IEntity).Assembly;

            builder.RegisterAllEntities<IEntity>(entitiesAssembly);
            builder.RegisterEntityTypeConfiguration(entitiesAssembly);
            builder.AddRestrictDeleteBehaviorConvention();
            builder.AddSequentialGuidForIdConvention();
            builder.AddPluralizingTableNameConvention();

        }
    }
}
