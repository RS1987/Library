using Library.Domain.Common.Generic;
using Library.Entities;
using System.Data.Entity;

namespace Library.Repositories
{
    public class TCardRepository : DbRepository<TCard>
    {
        public TCardRepository(DbContext context) : base(context)
        {
        }
    }
}


