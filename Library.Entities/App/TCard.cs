using Library.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class TCard : DbEntity
    {
        public virtual Librarian Librarian { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Book Book { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime? DateIn { get; set; }
    }
}
