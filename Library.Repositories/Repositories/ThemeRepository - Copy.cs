using Library.Domain.Common.Generic;
using Library.Entities;
using System.Data.Entity;

namespace Library.Repositories
{
    public class PressRepository : DbRepository<Press>
    {
        public PressRepository(DbContext context) : base(context)
        {
        }
    }
}