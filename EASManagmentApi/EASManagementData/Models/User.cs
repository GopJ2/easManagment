using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASManagementData.Models
{
    public class User : IdentityUser<Guid>
    {
        public List<UserCompany> UserCompanies { get; set; }
    }
}
