using System;
using System.Diagnostics.Metrics;

public class LibraryCatalog {
    List<Book> bookList = new List<Book>();

    /* Add Book Method */
    public void addBook() {
        Console.WriteLine("[+] ADD NEW BOOK TO CATALOG");
        string title = Util.customStringInput("[-] Insert Book Title : ");
        string author = Util.customStringInput("[-] Insert Book Author : ");
        int publicationYear = Util.customIntegerInput("[-] Insert Book Publication Year : ");
        bookList.Add(new Book(title, author, publicationYear));
        Console.WriteLine("[+] Book successfully added.");    }

    /* Delete Book by Title */
    public void deleteBook() {
        Console.WriteLine("[+] DELETE BOOK BY ID");
        showAllBook();

        int bookID = Util.customIntegerInput("[-] Input Book ID : ");
        if (bookID < 0 || bookID > bookList.Count) {
            Console.WriteLine("[ ] ID not found.");
        }
        else {
            bookList.RemoveAt(bookID - 1);
            Console.WriteLine("[ ] Selected book susccessfully deleted.");
        }

    }

    /* Find Book by Title */
    public void findBook() {
        Console.WriteLine("[+] SEARCH BOOK BY TITLE");
        string bookTitle = Util.customStringInput("[+] Insert title to search : ");
        bool isBookAvailable = ErrorHandlers.isTitleAvailable(bookList, bookTitle);

        if (isBookAvailable) { 
            Book searchedBook = bookList.Find(item => item.Title == bookTitle);
            Console.WriteLine($"[ ] {searchedBook.Title} ({searchedBook.PublicationYear}) by {searchedBook.Author}");
        }
    }

    /* Show All Books */
    public void showAllBook() {
        int counter = 1;
        Console.WriteLine("[+] CATALOG BOOK LIST");
        foreach (Book book in bookList) {
            Console.WriteLine($"[{counter}] {book.Title} ({book.PublicationYear}) by {book.Author}");
            counter++;
        }

    }

    /* Sample Data */
    public void insertSampleData() {
        Book sample1 = new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997);
        Book sample2 = new Book("To Kill a Mockingbird", "Harper Lee", 1960);
        Book sample3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925);
        Book sample4 = new Book("1984", "George Orwell", 1949);
        Book sample5 = new Book("The Catcher in the Rye", "J.D. Salinger", 1951);

        bookList.Add(sample1);
        bookList.Add(sample2);
        bookList.Add(sample3);
        bookList.Add(sample4);
        bookList.Add(sample5);

    }

}
