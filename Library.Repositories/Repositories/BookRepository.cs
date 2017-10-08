using Library.Domain.Common.Generic;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class BookRepository : DbRepository<Book>
    {
        public BookRepository(DbContext context) : base(context)
        {
        }
    }
}
