namespace library;

public class UnitTest1
{

    [Fact]
    public void Test1()
    {
        string libraryId = "1";
        Library library = new Library(libraryId, "Name", "Address");
        Librarian librarian = new Librarian();
        library.Librarians.Add(librarian);

        string watchmenISBN = "978-1779501127";
        string alanMooreId = "alan-moore";
        string daveGibbonsId = "dave-gibbons";

        Author alanMoore = new Author(alanMooreId, "Alan Moore", [watchmenISBN]);
        Author daveGibbons = new Author(daveGibbonsId, "Dave Gibbons", [watchmenISBN]);
        Book book = new Book(watchmenISBN, "Watchmen", new List<string> { alanMooreId, daveGibbonsId });

        library.Catalog.Books.Add(book);
        BookItem bookItem = new BookItem("someid", libraryId);
        library.Librarians[0].AddBookItem(bookItem);

        Member member = new Member();
        member.Checkout(bookItem);

        var lendings = librarian.GetBookLendingsOfMember(member);

        Assert.Equal(1, lendings.Count);
    }
}
