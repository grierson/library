namespace library;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string libraryId = "1";
        Library library = new Library(libraryId, "Name", "Address");

        string watchmenISBN = "978-1779501127";
        string alanMooreId = "alan-moore";
        string daveGibbonsId = "dave-gibbons";

        Author alanMoore = new Author(alanMooreId, "Alan Moore", [watchmenISBN]);
        Author daveGibbons = new Author(daveGibbonsId, "Dave Gibbons", [watchmenISBN]);

        library.Catalog.AddBook(
                watchmenISBN,
                "Watchmen",
                new List<string> { alanMooreId, daveGibbonsId });

        Librarian librarian = new Librarian();
        Book book = library.Catalog.GetBook(watchmenISBN);
        library.Catalog.AddBookItem(watchmenISBN);

        Guid memberId = library.AddMember();
        Member member = library.GetMember(memberId);

        library.Checkout(memberId, watchmenISBN);

        Assert.Single(member.MemberBookLendings);
        Assert.Single(book.BookItems[0].BookLending);
    }
}
