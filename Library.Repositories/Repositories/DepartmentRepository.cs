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
    public class DepartmentRepository : DbRepository<Department>
    {
        public DepartmentRepository(DbContext context) : base(context)
        {
        }
    }
}