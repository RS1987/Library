using Library.Entities;
using System.Data.Entity;

namespace Library.AppContext
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Press> Press { get; set; }
        public DbSet<Theme> Themes { get; set; }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; } 
       
        public DbSet<SCard> SCards { get; set; }
        public DbSet<TCard> TCards { get; set; }
        public DbSet<Librarian> Libs { get; set; }

        public ApplicationDbContext(string connStrName)
            : base(connStrName)
        {
            Database.SetInitializer<ApplicationDbContext>(
                new ApplicationDbContextInitializer());
        }
    }
}
