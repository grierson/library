
namespace library;

public class BookLending
{
    public string Id { get; set; }
    public DateTime LendingDate { get; set; }
    public DateTime DueDate { get; set; }

    public BookLending(string id, DateTime lendingDate, DateTime dueDate)
    {
        Id = id;
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

