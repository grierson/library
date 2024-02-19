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

    public void Checkout(BookLending bookLending)
    {
        BookLendings.Add(bookLending);
    }
}

