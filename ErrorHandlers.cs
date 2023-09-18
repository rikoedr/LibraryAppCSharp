using System;

public class ErrorHandlers {

    public static string stringCheck(string value) {
        try{
            if (string.IsNullOrWhiteSpace(value)) {
                throw new ArgumentException("[+] Input tidak boleh kosong.");
            }

            return value;
        }
        catch (ArgumentException error) {
            Console.WriteLine(error.Message);
            return "Empty Title";
        }
    }

    public static int integerParseCheck(string value) {
        try {
            int result;
            bool isParseable = int.TryParse(value, out result);

            return int.Parse(value);
        }
        catch (FormatException) {
            Console.WriteLine("[+] Input yang dimasukkan tidak sesuai.");
            return -1;
        }
    }

    public static bool isTitleAvailable(List<Book> bookList, string title) {
        try {
            int titleIndex = bookList.FindIndex(item => item.Title == title);

            if (titleIndex < 0) {
                throw new ArgumentException($"Buku {title} tidak terdaftar di dalam katalog");
            }

            return true;
        }catch(ArgumentException error) {
            Console.WriteLine(error.Message);
            return false;
        } 
    }
}
