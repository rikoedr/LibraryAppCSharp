public class LibraryApp {
    bool isAppRunning = true;
    LibraryCatalog libraryCatalog = new LibraryCatalog();
    public static void Main(string[] args) {
        LibraryApp libraryApp = new LibraryApp();
        libraryApp.start();
    }

    public void start() {
        libraryCatalog.insertSampleData();
        while (isAppRunning) {
            aplicationMenuUI();
            string userInput = Util.customStringInput("[+] Choice option : ");

            Console.WriteLine(" ");
            switch (userInput) {
                case "A":
                    libraryCatalog.addBook();
                    break;
                case "R":
                    libraryCatalog.deleteBook();
                    break;
                case "F":
                    libraryCatalog.findBook();
                    break;
                case "S":
                    libraryCatalog.showAllBook();
                    break;
                case "X":
                    isAppRunning = false;
                    break;
            }
            Util.temporaryPauseApp();
            Console.Clear();
        }
    }

    public void aplicationMenuUI() {
        Console.WriteLine("LIBRARY APPLICATION");
        Console.WriteLine("[A] ADD NEW BOOK");
        Console.WriteLine("[R] REMOVE BOOK");
        Console.WriteLine("[F] FIND BOOK BY TITLE");
        Console.WriteLine("[S] SHOW BOOKS LIST");
        Console.WriteLine("[X] EXIT");
    }
}