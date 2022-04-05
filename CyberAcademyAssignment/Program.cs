using System;

namespace CyberAcademyAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            book.Title = "Holiness";
            book.Author = "J.C. Ryle";
            book.ISBN = "978-92-95055-02-5";

            book.ReadableBooks();
            book.ShelvableBooks();
            Console.WriteLine("Title: {0} \nAuthor: {1} \nISBN: {2}",
                book.Title, book.Author, book.ISBN);
        }
    }
}
