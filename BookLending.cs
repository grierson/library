namespace library;

public class BookLending
{
    public List<Member> Member { get; set; }
    public BookItem BookItem { get; set; }

    public string Id { get; set; }
    public DateTime LendingDate { get; set; }
    public DateTime DueDate { get; set; }

    public BookLending(string id, DateTime lendingDate, DateTime dueDate)
    {
        Id = id;
        LendingDate = lendingDate;
        DueDate = dueDate;
        Member = new List<Member>();
        BookItem = new BookItem("BookId", "LibId");
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

