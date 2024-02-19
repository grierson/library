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

    public BookItem AddBookItem(BookItem bookItem)
    {

        return bookItem;
    }

    public List<BookLending> GetBookLendingsOfMember(Member member)
    {
        return member.BookLendings;
    }
}

