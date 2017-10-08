using Library.Domain.Common.Generic;
using Library.Entities;
using System.Data.Entity;

namespace Library.Repositories
{
    public class SCardRepository : DbRepository<SCard>
    {
        public SCardRepository(DbContext context) : base(context)
        {
        }
    }
}


