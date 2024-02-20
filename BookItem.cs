namespace library;

public class BookItem
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public bool IsLent { get; set; } = false;
    public List<BookLending> BookLending { get; set; } = new List<BookLending>();

    public BookLending Checkout(BookLending lending, Member member)
    {
        BookLending.Add(lending);
        IsLent = true;
        return lending;
    }

    public void ReturnBook(BookLending bookLending)
    {
        BookLending.Remove(bookLending);
        IsLent = false;
    }
}

