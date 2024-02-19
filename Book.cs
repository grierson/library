namespace library;

public class Book
{
    public string Id { get; set; }
    public string Title { get; set; }

    public List<string> AuthorIds { get; set; }
    public List<BookItem> BookItems { get; set; }

    public Book(string id, string title, List<string> authors)
    {
        Id = id;
        Title = title;
        AuthorIds = authors;
    }
}

