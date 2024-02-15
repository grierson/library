namespace library;

public class Author
{
    public string Id { get; set; }
    public string FullName { get; set; }

    public List<Book> Books { get; set; }

    public Author(string id, string fullName, List<Book> books)
    {
        Id = id;
        FullName = fullName;
        Books = books;
    }
}

