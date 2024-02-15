namespace library;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }

    public List<Author> Authors { get; set; }
    public List<BookItem> BookItems { get; set; } = new List<BookItem>();

    public Book(string id, string title, List<Author> authors)
    {
        Id = id;
        Title = title;
        Authors = authors;
    }
}

