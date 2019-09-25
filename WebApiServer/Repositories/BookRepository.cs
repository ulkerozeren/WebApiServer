using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiServer.Entities;
using WebApiServer.Interfaces;

namespace WebApiServer.Repositories
{
    public class BookRepository:Repository<Book>, IBookRepository
    {
        private readonly XContext _xContext;
        public BookRepository(XContext xContext):base(xContext)
        {
            _xContext = xContext;
        }
    }
}
