namespace library;

public class Catalog
{
    public List<Book> Books { get; set; } = new List<Book>();

    public List<Book> Search(string searchCriteria, string queryString)
    {
        return Books.Where(book =>
            book.Title.Contains(queryString, StringComparison.OrdinalIgnoreCase) ||
            book.Authors.Any(author => author.FullName.Contains(queryString, StringComparison.OrdinalIgnoreCase))).ToList();
    }

    public BookItem AddBookItem(Librarian librarian, Member member, BookItem bookItem)
    {
        return librarian.AddBookItem(member, bookItem);
    }
}

