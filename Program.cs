using System;

namespace bookStoreWithCount
{
    class myStoreWithCount
    {
        static void Main(string[] args)
        {
            // Creating book objects
            BookWithCount book1 = new BookWithCount(); // Using default constructor
            book1.SetId(1);
            book1.SetTitle("The Great Gatsby");
            book1.SetAuthor("F. Scott Fitzgerald");
            book1.SetTrans();

            BookWithCount book2 = new BookWithCount(); // Using default constructor with user input
            Console.WriteLine("Please enter the book ID: ");
            book2.SetId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book title: ");
            book2.SetTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book author: ");
            book2.SetAuthor(Console.ReadLine());
            book2.SetTrans();

            BookWithCount book3 = new BookWithCount(2, "To Kill a Mockingbird", "Harper Lee"); // Using parameterized constructor
            book3.SetTrans();

            Console.WriteLine("Please enter the book ID: ");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the book title: ");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the book author: ");
            string tempAuthor = Console.ReadLine();
            BookWithCount book4 = new BookWithCount(tempID, tempTitle, tempAuthor); // Using parameterized constructor with user input
            book4.SetTrans();

            // Displaying total transactions
            Console.WriteLine("Total transactions: " + BookWithCount.GetTrans());

            // Displaying book information
            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);
        }

        // Method to display book information
        static void displayBooks(BookWithCount book)
        {
            Console.WriteLine("Book ID: " + book.GetId());
            Console.WriteLine("Title: " + book.GetTitle());
            Console.WriteLine("Author: " + book.GetAuthor());
            Console.WriteLine();
        }
    }

    // Book class with count
    class BookWithCount
    {
        // Private fields
        private int _Id;
        private string _Title;
        private string _Author;
        private static int _transactions = 0;

        // Default constructor
        public BookWithCount()
        {
        }

        // Parameterized constructor
        public BookWithCount(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }

        // Get and Set methods for _Id field
        public int GetId()
        {
            return _Id;
        }

        public void SetId(int id)
        {
            _Id = id;
        }

        // Get and Set methods for _Title field
        public string GetTitle()
        {
            return _Title;
        }

        public void SetTitle(string title)
        {
            _Title = title;
        }

        // Get and Set methods for _Author field
        public string GetAuthor()
        {
            return _Author;
        }

        public void SetAuthor(string author)
        {
            _Author = author;
        }

        // Method to set transaction count
        public void SetTrans()
        {
            _transactions++;
        }

        // Method to get transaction count
        public static int GetTrans()
        {
            return _transactions;
        }
    }

}
