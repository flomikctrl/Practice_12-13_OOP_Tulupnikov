using LibraryApp.Models;
using LibraryApp.Services;

namespace LibraryApp {
    internal class Program {
        private static void Main(string[] args) {
            Console.WriteLine("Система управления библиотекой");

            var library = new Library("Городская библиотека №1");
            var service = new LibraryService(library);

            Console.WriteLine("Добавление книг");
            library.AddBook("Война и мир", "Л.Н. Толстой", 1869, "Роман");
            library.AddBook("Преступление и наказание", "Ф.М. Достоевский", 1866, "Роман");
            library.AddBook("Мастер и Маргарита", "М.А. Булгаков", 1967, "Роман");
            library.AddBook("Анна Каренина", "Л.Н. Толстой", 1877, "Роман");
            library.AddBook("Идиот", "Ф.М. Достоевский", 1869, "Роман");

            library.DisplayAllBooks();

            Console.WriteLine("\nВыдача книг");
            service.CheckOutBook(1);
            service.CheckOutBook(3);

            service.ShowAvailableBooks();
            service.SearchByAuthor("Толстой");

            Console.WriteLine("\nВозврат книги");
            service.ReturnBook(1);

            service.ShowStatistics();

            Console.WriteLine("\nПроверка повторной выдачи");
            service.CheckOutBook(3);

            Console.WriteLine("\nПрограмма завершена. Нажмите Enter...");
            Console.ReadLine();
        }
    }
}