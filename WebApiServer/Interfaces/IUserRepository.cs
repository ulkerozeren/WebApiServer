using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiServer.Entities;

namespace WebApiServer.Interfaces
{
    public interface IUserRepository: IRepository<User>
    {
    }
}
