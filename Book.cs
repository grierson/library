namespace library;

public class Book(string isbn, string title, List<string> authors)
{
    public string Isbn { get; set; } = isbn;
    public string Title { get; set; } = title;

    public List<string> AuthorIds { get; set; } = authors;
    public List<BookItem> BookItems { get; set; } = new List<BookItem>();

    public BookItem AddBookItem()
    {
        BookItem bookItem = new BookItem();
        BookItems.Add(bookItem);
        return bookItem;
    }

    public BookItem GetAvailableBookItem()
    {
        var bookitem = BookItems.Where(x => !x.IsLent).FirstOrDefault();
        return bookitem;
    }
}

