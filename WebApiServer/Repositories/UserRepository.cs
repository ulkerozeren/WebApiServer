using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiServer.Entities;
using WebApiServer.Interfaces;

namespace WebApiServer.Repositories
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        private readonly XContext _xContext;
        public UserRepository(XContext xContext):base(xContext)
        {
            _xContext = xContext;
        }
    }
}
