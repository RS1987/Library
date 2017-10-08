using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.WebApp.Models
{
    public class BookVM
    {
        public string Name { get; set; }
        public IEnumerable<String> Authors { get; set; }
        public string Press { get; set; }
        public string Category { get; set; }
        public string Theme { get; set; }
        public int Quantity { get; set; }        
    }
}