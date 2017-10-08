using Library.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace Library.AppContext
{
    //CreateDatabaseIfNotExists: инициализатор, используемый по умолчанию.Он не удаляет автоматчески базу данных и данные, а в случае изменения структуры моделей и контекста данных выбрасывает исключение.
    //DropCreateDatabaseIfModelChanges: данный инициализатор проверяет на соответствие моделям определения таблиц в базе данных.И если модели не соответствуют определению таблиц, то база данные пересоздается
    //DropCreateDatabaseAlways: этот инициализатор будет всегда пересоздавать базу данных.

    class ApplicationDbContextInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Libs.Add(new Librarian { FirstName = "Vasa", LastName = "Pupkin" });
            context.Books.Add(
                new Book
                {
                    Name = "Asp.Net Programming",
                    Category = new Category { Name = "Справочники" },
                    Theme = new Theme { Name = "C#" },
                    Authors = new List<Author> { new Author { FirstName = "Стивен", LastName = "Сандерсон" } },
                    Press = new Press { Name = "Вильямс" },
                    Quantity = 10
                });

            context.SaveChanges();
        }
    }
}
