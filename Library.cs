using System;
using System.Collections.Generic;

namespace LibraryApp
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ListBooks()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(
                    $"{book.Title} - {book.Author} | Available: {book.IsAvailable}"
                );
            }
        }

        public void BorrowBook(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title && book.IsAvailable)
                {
                    book.IsAvailable = false;
                    Console.WriteLine("Book borrowed successfully.");
                    return;
                }
            }
            Console.WriteLine("Book not available.");
        }
    }
}
