using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("Simyacı", "Paulo Coelho");

            library.AddBook(book1);
            library.AddBook(book2);

            Console.WriteLine("Library Books:");
            library.ListBooks();

            Console.WriteLine("\nBorrowing '1984'...");
            library.BorrowBook("1984");

            Console.WriteLine("\nUpdated Book List:");
            library.ListBooks();
        }
    }
}
