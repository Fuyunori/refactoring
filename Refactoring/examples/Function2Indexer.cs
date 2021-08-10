namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Method_to_Indexer.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert 'GetBookAt' and 'Insert' methods into indexer
    namespace Function2Indexer.Task
    {
        class TestBookLibrary
        {
            Book[] _books;
            Book GetBookAt(int index)
            {
                return _books[index];
            }
            void Insert(int index, Book book)
            {
                _books[index] = book;
            }
            void Copy(int copy, int to)
            {
                Insert(to, GetBookAt(copy));
            }
        }
    }
    
    namespace Function2Indexer.Solution
    {
        class TestBookLibrary
        {
            Book[] _books;

            Book this[int index]
            {
                get { return _books[index]; }
                set { _books[index] = value; }
            }

            void Copy(int copy, int to)
            {
                this[to] = this[copy];
            }
        }
    }
}