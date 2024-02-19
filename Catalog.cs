namespace library;

public class Catalog
{
    private List<Book> Books { get; set; } = new List<Book>();

    public List<Book> Search(string searchCriteria, string queryString)
    {
        return Books.ToList();
    }

    public Book AddBook(string isbn, string title, List<string> authors)
    {
        Book book = new Book(isbn, title, authors);
        Books.Add(book);

        return book;
    }

    public Book GetBook(string isbn)
    {
        return Books.FirstOrDefault(b => b.Isbn == isbn);
    }

    public BookItem AddBookItem(string isbn)
    {
        Book book = Books.FirstOrDefault(b => b.Isbn == isbn);

        var bookitem = book.AddBookItem();

        return bookitem;
    }
}

