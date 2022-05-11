using System;
using System.Collections.Generic;
using System.Linq;

namespace broker;

public class Factory
{
    // creates new books and stores them in simple map 
    // awaits Broker requests, that searches for the book

    protected Dictionary<Book, int> books;


    public Factory()
    {
        books = new Dictionary<Book, int>();
        for (int i = 0; i < (int) Book.Titles.SIZE; i++)
        {
            books.Add(new Book((Book.Titles) i), 0);
        }

        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            foreach (Book book in books.Keys.ToList())
            {
                if (rnd.NextDouble() < book.GenerationChance)
                    books[book] += 1;
            }
        }
    }
    
    public Dictionary<Book, int> GetBooks()
    {
        return this.books;
    }
}