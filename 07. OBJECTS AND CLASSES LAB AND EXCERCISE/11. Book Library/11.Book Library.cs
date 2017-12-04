using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


class Book
{
    public string Title{ get; set; }
    public string Author{ get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int ISBN { get; set; }
    public double Price { get; set; }

    public static Book ReadABook()
    {
        var input = Console.ReadLine().Split(' ').ToList();
        Book currentBook = new Book()
        {
            Title = input[0],
            Author = input[1],
            Publisher = input[2],
            ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
            ISBN = int.Parse(input[4]),
            Price = double.Parse(input[5]),
            
        
        };
        return currentBook;
    }
}

class Library
{
    public string Name { get; set; }
    public List<Book> Books { get; set; }
}

class Authors
{
    public string Author { get; set; }
    public double Price { get; set; }
}





class Program
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        Library lib = new Library()
        {
            Name = "Prosveta",
            Books = new List<Book>(),
        };
        for (int i = 0; i < n; i++)
        {
            var input = Book.ReadABook();
            lib.Books.Add(input);
        }

        var byAuthor = lib.Books.Select(a => a.Author).Distinct().ToList();
        var authorSales = new List<Authors>();

        foreach (var author in byAuthor)
        {
            var authorBooksAndSumPrice = lib.Books.Where(a => a.Author == author).Sum(a => a.Price);
            var authorInfo = new Authors()
            {
                Author = author,
                Price = authorBooksAndSumPrice
            };
            authorSales.Add(authorInfo);

        }
        foreach (var item in authorSales)
        {
            Console.WriteLine($"{item.Author} -> {item.Price}");
        }

    }
}


