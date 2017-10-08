using Library.Domain.Common.Generic;
using Library.Entities;
using System.Data.Entity;

namespace Library.Repositories
{
    public class AuthorRepository : DbRepository<Author>
    {
        public AuthorRepository(DbContext context) : base(context)
        {
        }
    }
}
