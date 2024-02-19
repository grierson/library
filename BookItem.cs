namespace library;

public class BookItem()
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public List<BookLending> BookLending { get; set; } = new List<BookLending>();

    public BookLending Checkout(Member member)
    {
        var lending = new BookLending(member.Id, DateTime.Now, DateTime.Now.AddDays(14));
        BookLending.Add(lending);
        return lending;
    }
}

