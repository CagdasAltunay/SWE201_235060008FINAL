namespace LibraryApp
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        
// Constructor for creating a new book object
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true;
        }
    }
}
