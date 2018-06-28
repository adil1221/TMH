using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TMH.Core.Entity;

namespace TMH.Core.DbContext
{
    public class TMHContext : IdentityDbContext<ApplicationUser, ApplicationRole, long>
    {
        public TMHContext(DbContextOptions options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        #region JunkCode  /*configuration placed inside startup.cs ,will be removed after proper testing*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:LAPTOP-MADIL;Initial Catalog=TMH;Persist Security Info=False;User ID=sa;Password=tenpearls;");
            }
        }
        #endregion
    }
}
