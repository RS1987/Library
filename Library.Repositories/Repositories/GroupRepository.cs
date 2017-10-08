using Library.Domain.Common.Generic;
using Library.Entities;
using System.Data.Entity;

namespace Library.Repositories
{
    public class GroupRepository : DbRepository<Group>
    {
        public GroupRepository(DbContext context) : base(context)
        {
        }
    }
}
