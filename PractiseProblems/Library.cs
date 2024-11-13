using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProblems
{
    class Library
    {
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            if(book != null )
            {
                Books.Add(book);
            }

        }
        public void RemoveBook(string bookName)
        {
            Books.Remove(Books.FirstOrDefault(u => u.Name == bookName));
        }
        public List<Book> GetBooks()
        {
            return Books;
        }
    }
   
}

public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
}