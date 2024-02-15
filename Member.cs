namespace library;

public class Member : User
{
    public List<BookLending> BookLendings { get; set; } = new List<BookLending>();

    public bool IsBlocked()
    {
        return false;
    }

    public bool Block()
    {
        return true;
    }

    public bool Unblock()
    {
        return true;
    }

    public BookLending ReturnBook(BookLending bookLending)
    {
        return bookLending;
    }

    public BookLending Checkout(BookItem bookItem)
    {
        return bookItem.Checkout(this);
    }
}

