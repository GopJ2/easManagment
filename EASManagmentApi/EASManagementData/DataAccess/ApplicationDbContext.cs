using EASManagementData.Builders;
using EASManagementData.Builders.UserCompanies;
using EASManagementData.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace EASManagementData.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, Guid>
    {
        public DbSet<UserCompany> UserCompanies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.BuildUsersRoles();
            builder.BuildUserCompanies();
        }
    }
}
