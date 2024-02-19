namespace library;

public class Author
{
    public string Id { get; set; }
    public string FullName { get; set; }

    public List<string> BookIds { get; set; }

    public Author(string id, string fullName, List<string> books)
    {
        Id = id;
        FullName = fullName;
        BookIds = books;
    }
}

