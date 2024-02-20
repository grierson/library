
namespace library;

public class BookLending
{
    public Guid Id { get; set; }
    public Guid MemberId { get; private init; }
    public DateTime LendingDate { get; set; }
    public DateTime DueDate { get; set; }

    public BookLending(Guid memberId, DateTime lendingDate, DateTime dueDate)
    {
        Id = Guid.NewGuid();
        MemberId = memberId;
        LendingDate = lendingDate;
        DueDate = dueDate;
    }

    public bool IsLate()
    {
        return false;
    }

    public bool ReturnBook()
    {
        return true;
    }
}

