namespace library;

public class Library(string id, string name, string address)
{
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Address { get; set; } = address;

    public Catalog Catalog { get; set; } = new Catalog();
    private List<Librarian> Librarians { get; set; } = new List<Librarian>();
    private List<Member> Members { get; set; } = new List<Member>();

    public Guid AddMember()
    {
        var id = Guid.NewGuid();
        var member = new Member(id);
        Members.Add(member);
        return id;
    }

    public List<Member> GetMembers()
    {
        return Members.ToList();
    }

    public Member GetMember(Guid id)
    {
        return Members.FirstOrDefault(x => x.Id == id);
    }

    public Librarian GetLibrarian(Guid id)
    {
        return Librarians.FirstOrDefault(x => x.Id == id);
    }

    public Guid AddLibrarian()
    {
        var librarian = new Librarian();
        Librarians.Add(librarian);
        return librarian.Id;
    }

    public void Checkout(Guid memberId, string isbn)
    {
        Book book = Catalog.GetBook(isbn);
        Member member = GetMember(memberId);
        BookItem bookItem = book.GetAvailableBookItem();
        var lending = new BookLending(member.Id, DateTime.Now, DateTime.Now.AddDays(14));
        member.Checkout(lending);
        bookItem.Checkout(lending, member);
    }
}

