using Library.Domain.Common.Generic;
using Library.Entities;
using System.Data.Entity;

namespace Library.Repositories
{
    public class ThemeRepository : DbRepository<Theme>
    {
        public ThemeRepository(DbContext context) : base(context)
        {
        }
    }
}