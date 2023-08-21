namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Create sample books
            Book book1 = new Book
            {
                Title = "Harry Potter and the Sorcerer's Stone",
                Author = "J.K. Rowling",
                ISBN = "978-0590353427",
                IsAvailable = true
            };

            Book book2 = new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ISBN = "978-0061120084",
                IsAvailable = true
            };

            Book book3 = new Book
            {
                Title = "1984",
                Author = "George Orwell",
                ISBN = "978-0451524935",
                IsAvailable = true
            };

            Book book4 = new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "978-0743273565",
                IsAvailable = true
            };

            Book book5 = new Book
            {
                Title = "Pride and Prejudice",
                Author = "Jane Austen",
                ISBN = "978-0141439518",
                IsAvailable = true
            };

            // Create sample users
            User user1 = new User
            {
                Name = "Alice",
                Email = "alice@example.com"
            };

            User user2 = new User
            {
                Name = "Bob",
                Email = "bob@example.com"
            };

            User user3 = new User
            {
                Name = "Charlie",
                Email = "charlie@example.com"
            };

            User user4 = new User
            {
                Name = "David",
                Email = "david@example.com"
            };

            // Add sample data to library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            library.AddUser(user1);
            library.AddUser(user2);
            library.AddUser(user3);
            library.AddUser(user4);

            Console.WriteLine("......................................");

            // Start the library management system
            library.Start();
           
        }
    }
}