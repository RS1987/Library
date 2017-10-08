using Library.Domain.Common.Generic;
using Library.Entities;
using System.Data.Entity;

namespace Library.Repositories
{
    public class LibrarianRepository : DbRepository<Librarian>
    {
        public LibrarianRepository(DbContext context) : base(context)
        {
        }
    }
}
