using FluentAPI;
using Microsoft.EntityFrameworkCore;

using (ApplicationDbContext db = new ApplicationDbContext())
{
    /*var publisher1 = new Publisher { Name = "pub1" };
    var publisher2 = new Publisher { Name = "pub2" };

    Autors autor1 = new Autors { LastName = "Brock" };
    Autors autor2 = new Autors { LastName = "Dale" };
    Autors autor3 = new Autors { LastName = "Moses" };

    db.Publishers.AddRange(publisher1, publisher2);
    db.Autors.AddRange(autor1, autor2, autor3);
    db.SaveChanges();

    Books book1 = new Books { Title = "Book1", Pages = 100, Price = 70, Publisher = publisher1};
    book1.Autors.Add(autor1); 
    Books book2 = new Books { Title = "Book2", Pages = 500, Price = 270, Publisher = publisher1 };
    book2.Autors.Add(autor2);
    Books book3 = new Books { Title = "Book3", Pages = 200, Price = 140 , Publisher = publisher2 };
    book3.Autors.Add(autor3);

    db.Books.AddRange(book1, book2, book3);
    db.SaveChanges();*/

    /*
    var books = db.Books.ToList();
    foreach (var book in books)
    {
        Console.WriteLine($"{book.Title}, {book.Price}, {book.Pages}");
    }
    var autor = db.Autors.ToList();

    foreach( var a in autor)
    {
        Console.WriteLine($"{a.LastName}");
    }
    var result = db.Autors.OrderBy(a=> a.Id).LastOrDefault();
    result.LastName ="changed last name";
    db.SaveChanges();

    var autor2 = db.Autors.ToList();

    foreach (var a in autor2)
    {
        Console.WriteLine($"{a.LastName}");
    }*/

    /*var books2 = db.Books.Find(4);

    if (books2 != null)
    {
        db.Books.Remove(books2);
        db.SaveChanges();
    }

    var publisher = db.Publishers.Find(2);
    if (publisher != null)
    {
        db.Publishers.Remove(publisher);
        db.SaveChanges();
    }*/

/*    var author = db.Autors.Find(1);

    if (author != null)
    {
        foreach (var book in author.Books)
        {
            Console.WriteLine($"Book Title: {book.Title}, Price: {book.Price}");

            Console.WriteLine($"Publisher: {book.Publisher.Name}");
        }
    }*/
    

}
