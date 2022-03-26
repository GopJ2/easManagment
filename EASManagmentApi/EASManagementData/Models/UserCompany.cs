using EASManagementCommon.Enum.UserCompany;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASManagementData.Models
{
    public class UserCompany: BaseEntity
    {
        public User User { get; set; }

        public Company Company { get; set; }

        public UserCompanyTypeEnum UserRelationType { get; set; }
    }
}
