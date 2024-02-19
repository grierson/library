namespace library;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string libraryId = "1";
        Library library = new Library(libraryId, "Name", "Address");
        library.AddLibrarian();

        string watchmenISBN = "978-1779501127";
        string alanMooreId = "alan-moore";
        string daveGibbonsId = "dave-gibbons";

        Author alanMoore = new Author(alanMooreId, "Alan Moore", [watchmenISBN]);
        Author daveGibbons = new Author(daveGibbonsId, "Dave Gibbons", [watchmenISBN]);

        library.Catalog.AddBook(
                watchmenISBN,
                "Watchmen",
                new List<string> { alanMooreId, daveGibbonsId });

        library.Catalog.AddBookItem(watchmenISBN);
        library.AddMember();
        Member member = library.GetMembers().FirstOrDefault();
        library.Checkout(member, watchmenISBN);
        var lendings = member.BookLendings;

        var lending = lendings.First();
        Console.WriteLine(lending.Id);
        Console.WriteLine(member.Id);
        Console.WriteLine(lending.MemberId);

        Assert.Single(lendings);
    }
}
