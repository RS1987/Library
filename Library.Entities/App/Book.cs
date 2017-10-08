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
    [Table("Books")]
    public class Book : DbEntity
    {
        [StringLength(64)]
        public string Name { get; set; }
        public virtual List<Author> Authors { get; set; }

        public virtual Press Press { get; set; }
        public virtual Category Category { get; set; }
        public virtual Theme Theme { get; set; }

        public int Quantity { get; set; }

        public virtual List<SCard> SCards { get; set; }
        public virtual List<TCard> TCards { get; set; }

    }
}
