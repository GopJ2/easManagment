using EASManagementData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASManagementData.Builders.UserCompanies
{
    public static class UserCompanyBuilder
    {
        public static void BuildUserCompanies(this ModelBuilder builder)
        {
            builder.Entity<UserCompany>(b =>
            {
                b.HasOne(u => u.User).WithMany(p => p.UserCompanies);
            });

            builder.Entity<UserCompany>(b =>
            {
                b.HasOne(u => u.Company).WithMany(p => p.CompaniesUsers);
            });
        }
    }
}
