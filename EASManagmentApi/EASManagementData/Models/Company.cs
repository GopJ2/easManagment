using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASManagementData.Models
{
    public class Company: BaseEntity
    {
        public List<UserCompany> CompaniesUsers { get; set; }
    }
}
