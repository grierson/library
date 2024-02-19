namespace library;

public class Catalog
{
    public List<Book> Books { get; set; } = new List<Book>();

    public List<Book> Search(string searchCriteria, string queryString)
    {
        return Books.ToList();
    }

    public BookItem AddBookItem(Librarian librarian, BookItem bookItem)
    {
        return librarian.AddBookItem(bookItem);
    }
}

