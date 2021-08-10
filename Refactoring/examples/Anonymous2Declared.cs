using System.Collections.Generic;
using System.Linq;
using Refactoring.examples.Anonymous2Declared.Solution;

namespace Refactoring.examples
{
    class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }
    
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Anonymous_to_Named_Type.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert the anonymous type in both methods to a named type called 'BookList'
    namespace Anonymous2Declared.Task
    {
        class MyTest
        {
            void Test(List<Book> books)
            {
                var bookList = from book in books select new { book.Author, book.Title };
            }
        }
    
        class MyNewTest
        {
            void Foo(List<Book> library)
            {
                var bookCatalog = from item in library select new { item.Author, item.Title };
            }
        }
    }
    
    namespace Anonymous2Declared.Solution
    {
        public class BookList
        {
            public string Author { get; set; }
            public string Title { get; set; }
        }

        class MyTest
        {
            void Test(List<Book> books)
            {
                var bookList = from book in books select new BookList {Author = book.Author, Title = book.Title};
            }
        }
    
        class MyNewTest
        {
            void Foo(List<Book> library)
            {
                var bookCatalog = from item in library select new BookList {Author = item.Author, Title = item.Title};
            }
        }
    }
}