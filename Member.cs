namespace library;

public class MemberBookLending
{
    public Guid Id { get; private set; }
    public Guid LibraryBookLendingId { get; private set; }
    public DateTime LendingDate { get; private set; }
    public DateTime DueDate { get; private set; }

    public MemberBookLending(Guid libraryBookLendingId, DateTime lendingDate, DateTime dueDate)
    {
        Id = Guid.NewGuid();
        LibraryBookLendingId = libraryBookLendingId;
        LendingDate = lendingDate;
        DueDate = dueDate;
    }
}

public class Member
{
    public Guid Id { get; private set; }
    public List<MemberBookLending> MemberBookLendings { get; private set; } = new List<MemberBookLending>();

    public Member(Guid id)
    {
        Id = id;
    }

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
        MemberBookLendings.Add(new MemberBookLending(bookLending.Id, bookLending.LendingDate, bookLending.DueDate));
    }

    public MemberBookLending GetBookLending(Guid id)
    {
        return MemberBookLendings.FirstOrDefault(x => x.Id == id);
    }
}

