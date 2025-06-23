using LinqJoin_Example;

//listeleri tanımladık
//alternatif olarak var authors = new List<Authors> şeklinde de tanımlanabilir.
List<Authors> authors = new List<Authors>
{
    new(1, "Gabriel Garcia Marquez"),
    new(2, "Sally Rooney"),
    new(3, "Virgina Woolf"),
    new(4, "Arkadi, Boris Strugatski")
};

List<Books> books = new List<Books>
{
    new(1, "Kolera Günlerinde Aşk", 1),
    new(2, "Normal İnsanlar", 2),
    new(3, "Orlando", 3),
    new(4, "Kendine Ait Bir Oda", 3),
    new(5, "Tanrı Olmak Zor İş", 4)
};

//Linq sorgularını yazıyoruz.

// LINQ sorgusunda join işlemini kullanarak iki tabloyu birleştirin

//metot söz dizimi
/*
var authorsWithBooks = authors.Join(books,
                                   author => author.AuthorId,
                                   book => book.AuthorId,
                                   (author, book) => new
                                   {
                                       AuthorName = author.Name,
                                       BookTitle = book.Title,
                                       
                                   });

*/

//sorgu söz dizimiyle

var authorsWithBooks = from author in authors
                       join book in books
                       on author.AuthorId equals book.AuthorId

                       select new
                       {
                           AuthorName = author.Name,
                           BookTitle = book.Title,
                       };

foreach (var item in authorsWithBooks)
{
    Console.WriteLine($"Yazarın Adı: {item.AuthorName} \nKitabın Adı: {item.BookTitle}");
    Console.WriteLine();
}
