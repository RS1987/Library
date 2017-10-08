using Library.Domain.Common.Generic;
using Library.Entities;
using System.Data.Entity;

namespace Library.Repositories
{
    public class StudentRepository : DbRepository<Student>
    {
        public StudentRepository(DbContext context) : base(context)
        {
        }
    }
}