namespace library;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var library = new Library("Name", "Address");

        Librarian librarian = new Librarian();
        Member member = new Member();
        BookItem bookItem = new BookItem("id", "libid");

        library.Catalog.AddBookItem(librarian, member, bookItem);

        Assert.Equal(1, library.Catalog.Books.Count);
    }
}
