namespace LibraryApp.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Genre { get; set; } = string.Empty;
    public bool IsAvailable { get; set; } = true;

    public void CheckOut()
    {
        if (IsAvailable)
        {
            IsAvailable = false;
            Console.WriteLine($"+ Книга '{Title}' выдана");
        }
        else
        {
            Console.WriteLine($"- Книга '{Title}' уже выдана");
        }
    }

    public void Return()
    {
        if (!IsAvailable)
        {
            IsAvailable = true;
            Console.WriteLine($"+ Книга '{Title}' возвращена");
        }
        else
        {
            Console.WriteLine($"- Книга '{Title}' уже в библиотеке");
        }
    }

    public override string ToString()
    {
        var status = IsAvailable ? "Доступна" : "Выдана";
        return $"[{Id}] '{Title}' ({Author}, {Year}) - {status}";
    }
}