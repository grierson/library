namespace library;

public class Librarian : User
{
    public bool BlockMember(Member member)
    {
        return member.Block();
    }

    public bool UnblockMember(Member member)
    {
        return member.Unblock();
    }

    public BookItem AddBookItem(Member member, BookItem bookItem)
    {
        var lending = member.Checkout(bookItem);
        member.BookLendings.Add(lending);
        return bookItem;
    }

    public List<BookLending> GetBookLendingsOfMember(Member member)
    {
        return member.BookLendings;
    }
}

