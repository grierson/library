namespace library;

public class Member : User
{
    public List<BookLending> BookLendings { get; set; } = new List<BookLending>();

    public bool Block()
    {
        return true;
    }

    public bool Unblock()
    {
        return true;
    }

    public bool IsBlocked()
    {
        return false;
    }

    public bool ReturnBook(BookLending bookLending)
    {
        return true;
    }

    public BookLending Checkout(BookItem bookItem)
    {
        var lending = bookItem.Checkout(this);
        BookLendings.Add(lending);

        return lending;
    }
}

