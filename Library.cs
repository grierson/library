namespace library;

public class Library(string id, string name, string address)
{
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Address { get; set; } = address;

    public Catalog Catalog { get; set; } = new Catalog();
    private List<Member> Members { get; set; } = new List<Member>();
    private List<Librarian> Librarians { get; set; } = new List<Librarian>();

    public void AddMember()
    {
        var member = new Member();
        Members.Add(member);
    }

    public List<Member> GetMembers()
    {
        return Members.ToList();
    }

    public Member GetMember(string memberId)
    {
        return Members.FirstOrDefault(x => x.Id == memberId);
    }

    public void AddLibrarian()
    {
        var librarian = new Librarian();
        Librarians.Add(librarian);
    }

    public void Checkout(Member member, string isbn)
    {
        Book book = Catalog.GetBook(isbn);
        BookItem bookItem = book.GetBookItem();
        var lending = new BookLending(member.Id, DateTime.Now, DateTime.Now.AddDays(14));
        member.Checkout(lending);
        bookItem.Checkout(member);
    }
}

