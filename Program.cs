using ClassLib;

namespace Indexer__List__Namespace__ClassLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Sherlock");
            book.AuthorName = "Sir Arthur Ignatius Conan Doyle";
            Book book2 = new Book("Frankenstein");
            Book book3 = new Book("1984");

            Library library = new Library();
            library.AddBook(book);
            library.AddBook(book2);
            library.AddBook(book3);


        }
    }
}
