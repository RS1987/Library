using Library.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    [Table("Departments")]
    public class Department : DbEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
        
        public virtual List<Teacher> Teachers { get; set; }
    }
}
