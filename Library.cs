namespace library;

public class Library(string id, string name, string address)
{
    public string Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Address { get; set; } = address;

    public Catalog Catalog { get; set; } = new Catalog();
    public List<Member> Members { get; set; } = new List<Member>();
    public List<Librarian> Librarians { get; set; } = new List<Librarian>();
}

