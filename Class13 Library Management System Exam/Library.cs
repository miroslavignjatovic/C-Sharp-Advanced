using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();
        private List<Transaction> transactions = new List<Transaction>();

        public void Start()
        {
            LoadData("books.json", "users.json", "transactions.json");
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Library Management System Menu:");
                Console.WriteLine("1. Search for a book");
                Console.WriteLine("2. Borrow a book");
                Console.WriteLine("3. Return a book");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter a keyword (title, author, or ISBN): ");
                        string keyword = Console.ReadLine();
                        List<Book> searchResults = FindBook(keyword);
                        Console.WriteLine("Search results:");
                        foreach (var book in searchResults)
                        {
                            Console.WriteLine($"- {book.Title} by {book.Author}");
                        }
                        break;
                    case "2":
                        Console.Write("Enter the user's name: ");
                        string userName = Console.ReadLine();
                        User user = users.FirstOrDefault(u => u.Name.Equals(userName, StringComparison.OrdinalIgnoreCase));

                        if (user == null)
                        {
                            Console.WriteLine("User not found.");
                        }
                        else
                        {
                            Console.Write("Enter the title of the book to borrow: ");
                            string bookTitle = Console.ReadLine();
                            Book bookToBorrow = books.FirstOrDefault(b =>
                                b.Title.Equals(bookTitle, StringComparison.OrdinalIgnoreCase) && b.IsAvailable);
                            
                            if (bookToBorrow == null)
                            {
                                Console.WriteLine("Book not found or not available.");
                            }
                            else
                            {
                                BorrowBook(user, bookToBorrow);
                            }

                        }
                        break;
                    case "3":
                        Console.Write("Enter the user's name: ");
                        string userNameReturn = Console.ReadLine();
                        User userReturn = users.FirstOrDefault(u => u.Name.Equals(userNameReturn, StringComparison.OrdinalIgnoreCase));

                        if (userReturn == null)
                        {
                            Console.WriteLine("User not found.");
                        }
                        else
                        {
                            Console.Write("Enter the title of the book to return: ");
                            string bookTitleReturn = Console.ReadLine();
                            Book bookToReturn = userReturn.CheckedOutBooks.FirstOrDefault(b =>
                                b.Title.Equals(bookTitleReturn, StringComparison.OrdinalIgnoreCase));

                            if (bookToReturn == null)
                            {
                                Console.WriteLine("Book not found or not checked out by this user.");
                            }
                            else
                            {
                                ReturnBook(userReturn, bookToReturn);
                            }
                        }
                        break;
                    case "4":
                        SaveData("books.json", "users.json", "transactions.json");
                        exit = true;
                        Console.WriteLine("Exiting the application and saving data.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }

        }
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Author}' add to library");
        }
        public void AddUser(User user)
        {
            users.Add(user);
            Console.WriteLine($"User '{user.Name}' add to library");
        }
        public List<Book> FindBook(string keyword)
        {
            var book = books.Where(book =>
                book.Title.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                book.Author.Contains(keyword, StringComparison.OrdinalIgnoreCase) ||
                book.ISBN.Equals(keyword, StringComparison.OrdinalIgnoreCase))
                .ToList();

            return book;
        }
        public bool BorrowBook(User user, Book book)
        {
            if (book.IsAvailable)
            {

                book.IsAvailable = false;


                user.CheckedOutBooks.Add(book);

                Transaction transaction = new Transaction
                {
                    User = user,
                    Book = book,
                    DateTime = DateTime.Now
                };
                transactions.Add(transaction);

                Console.WriteLine($"Book '{book.Title}' borrowed by {user.Name}.");
                return true;
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' is not available.");
                return false;
            }
        }
        public bool ReturnBook(User user, Book book)
        {
            if (user.CheckedOutBooks.Contains(book))
            {

                book.IsAvailable = true;


                user.CheckedOutBooks.Remove(book);


                Transaction transaction = new Transaction
                {
                    User = user,
                    Book = book,
                    DateTime = DateTime.Now
                };
                transactions.Add(transaction);

                Console.WriteLine($"Book '{book.Title}' returned by {user.Name}.");
                return true;
            }
            else
            {
                Console.WriteLine($"Book '{book.Title}' is not checked out by {user.Name}.");
                return false;
            }
        }
        public void LoadData(string booksFile, string usersFile, string transactionsFile)
        {
            if (File.Exists(booksFile))
            {
                string booksData = File.ReadAllText(booksFile);
                books = JsonConvert.DeserializeObject<List<Book>>(booksData);
            }

            if (File.Exists(usersFile))
            {
                string usersData = File.ReadAllText(usersFile);
                users = JsonConvert.DeserializeObject<List<User>>(usersData);
            }

            if (File.Exists(transactionsFile))
            {
                string transactionsData = File.ReadAllText(transactionsFile);
                transactions = JsonConvert.DeserializeObject<List<Transaction>>(transactionsData);
            }
        }
        public void SaveData(string booksFile, string usersFile, string transactionsFile)
        {
            File.WriteAllText(booksFile, JsonConvert.SerializeObject(books));
            File.WriteAllText(usersFile, JsonConvert.SerializeObject(users));
            File.WriteAllText(transactionsFile, JsonConvert.SerializeObject(transactions));
        }
    }

}



