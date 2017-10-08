using Library.Domain.Common.Generic;
using Library.Entities;
using System.Data.Entity;


namespace Library.Repositories
{
    public class FacultyRepository : DbRepository<Faculty>
    {
        public FacultyRepository(DbContext context) : base(context)
        {
        }
    }
}
