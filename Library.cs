namespace library;

public class Library
{
    public string Name { get; set; }
    public string Address { get; set; }

    public Catalog Catalog { get; set; } = new Catalog();
    public List<Member> Members { get; set; } = new List<Member>();
    public List<Librarian> Librarians { get; set; } = new List<Librarian>();

    public Library(string name, string address)
    {
        Name = name;
        Address = address;
    }
}

