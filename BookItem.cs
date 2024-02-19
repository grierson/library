namespace library;

public class BookItem(string id, string libId)
{
    public string Id { get; set; } = id;
    public string LibId { get; set; } = libId;
    public BookLending BookLending { get; set; } =
        new BookLending(libId, DateTime.Now, DateTime.Now.AddDays(14));

    public BookLending Checkout(Member member)
    {
        return BookLending;
    }
}

