using System;
using System.Collections.Generic;
using System.Linq;
using Pratik___Linq_Join;

class Program
{
    static void Main()
    {
        List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, Name = "Orhan Pamuk" },
            new Author { AuthorId = 2, Name = "Elif Safak" },
            new Author { AuthorId = 3, Name = "Ahmet Umit" }
        };

        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
            new Book { BookId = 2, Title = "Istanbul", AuthorId = 1 },
            new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
            new Book { BookId = 4, Title = "Beyoglu Rapsodisi", AuthorId = 3 }
        };

        var bookWithAuthors = from book in books
                              join author in authors on book.AuthorId equals author.AuthorId
                              select new { book.Title, author.Name };

        Console.WriteLine("Books and Their Authors:");
        foreach (var item in bookWithAuthors)
        {
            Console.WriteLine($"{item.Title} - {item.Name}");
        }
    }
}
