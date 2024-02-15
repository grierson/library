namespace library;

public class BookItem
{
    public string Id { get; set; }
    public string LibId { get; set; }

    public List<BookLending> Lendings { get; set; } = new List<BookLending>();

    public BookItem(string id, string libId)
    {
        Id = id;
        LibId = libId;
    }

    public BookLending Checkout(User member)
    {
        var lending = new BookLending(LibId, DateTime.Now, DateTime.Now.AddDays(14));
        Lendings.Add(lending);
        return lending;
    }
}

