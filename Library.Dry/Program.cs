using Library.Dry.Models;

namespace Library
{
    public static class Menu
    {
        private static readonly List<Book> Books = new List<Book>();
        private static readonly List<User> Users = new List<User>();
        private static readonly List<Loan> Loans = new List<Loan>();

        public static void Start()
        {
            Console.WriteLine("Welcome to the library management system!");
            while (true)
            {
                MainMenu();
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        RegisterEntity(RegisterBook, Books);
                        break;
                    case "2":
                        SearchEntity(SearchBook, Books);
                        break;
                    case "3":
                        ShowAllEntities(Books);
                        break;
                    case "4":
                        RemoveEntity(RemoveBook, Books);
                        break;
                    case "5":
                        RegisterEntity(RegisterUser, Users);
                        break;
                    case "6":
                        RegisterEntity(RegisterLoan, Loans);
                        break;
                    case "7":
                        ReturnBook();
                        break;
                    case "8":
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid option, please try again!");
                        break;
                }
            }
        }

        // Presentation methods

        #region Presentation
        private static void MainMenu()
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Select an option below:");
            Console.WriteLine("1 - Register a book");
            Console.WriteLine("2 - Search for a book");
            Console.WriteLine("3 - Show all books");
            Console.WriteLine("4 - Remove a book");
            Console.WriteLine("5 - Register a user");
            Console.WriteLine("6 - Register a loan");
            Console.WriteLine("7 - Return a book");
            Console.WriteLine("8 - Exit");
        } 
        #endregion

        // Generic methods for repetitive operations

        #region Generic methods
        private static void RegisterEntity<T>(Action action, List<T> list) where T : Model
        {
            action();
            Console.Clear();
            Console.WriteLine("Registered successfully!");
        }

        private static void SearchEntity<T>(Func<List<T>, bool> func, List<T> list) where T : Model
        {
            var result = func(list);
            if (!result)
            {
                Console.WriteLine("Not found!");
            }
        }

        private static void ShowAllEntities<T>(List<T> list) where T : Model
        {
            // Logic to display all books
        }

        private static void RemoveEntity<T>(Action action, List<T> list) where T : Model
        {
            action();
            // Logic to remove a book
        }
        #endregion

        // Specific methods for operations

        #region Specific methods

        private static void RegisterBook()
        {
            // Logic to register a book
        }

        private static bool SearchBook<T>(List<T> books) where T : Model
        {
            // Logic to search for a book
            return false; // or true, depending on the search logic
        }

        private static void RemoveBook()
        {
            // Logic to remove a book
        }

        private static void RegisterUser()
        {
            // Logic to register a user
        }

        private static void RegisterLoan()
        {
            // Logic to register a loan
        }

        private static void ReturnBook()
        {
            // Logic to register a loan
        } 
        #endregion
    }
}