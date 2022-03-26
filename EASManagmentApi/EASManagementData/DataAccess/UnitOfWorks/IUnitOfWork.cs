using EASManagementData.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EASManagementData.DataAccess.UnitOfWorks
{
    public interface IUnitOfWork: IDisposable
    {
        IUserRepository UserRepostory { get; }
        int Complete();
    }
}
