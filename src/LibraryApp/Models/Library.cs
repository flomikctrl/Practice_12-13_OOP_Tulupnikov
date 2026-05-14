using System;
using System.Collections.Generic;

namespace LibraryApp.Models;

public class Library
{
    private List<Book> books;
    private int nextId;

    public string? Name { get; set; }

    public Library(string name)
    {
        Name = name;
        books = new List<Book>();
        nextId = 1;
    }

    public void AddBook(string title, string author, int year, string genre)
    {
        var newBook = new Book
        {
            Id = nextId++,
            Title = title,
            Author = author,
            Year = year,
            Genre = genre
        };

        books.Add(newBook);
    }

    public Book? FindBookById(int id)
    {
        foreach (var book in books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }

        return null;
    }

    public List<Book> FindBooksByAuthor(string author)
    {
        var results = new List<Book>();
        var normalizedAuthor = author.Trim().ToLower();

        foreach (var book in books)
        {
            if (book.Author.ToLower().Contains(normalizedAuthor))
            {
                results.Add(book);
            }
        }

        return results;
    }

    public List<Book> GetAvailableBooks()
    {
        var availableBooks = new List<Book>();

        foreach (var book in books)
        {
            if (book.IsAvailable)
            {
                availableBooks.Add(book);
            }
        }

        return availableBooks;
    }

    public void DisplayAllBooks()
    {
        Console.WriteLine($"Библиотека '{Name}'");
        Console.WriteLine($"Всего книг: {books.Count}");

        if (books.Count == 0)
        {
            Console.WriteLine("Библиотека пуста");
            return;
        }

        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public int GetBookCount()
    {
        return books.Count;
    }
}