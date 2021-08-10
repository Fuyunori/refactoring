namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Indexer_to_Method.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert getter and setter accessors of the indexer to methods
    namespace Indexer2Function.Task
    {
        class BookLibrary
        {
            private Book[] books = new Book[1000];
            public Book this[int index]
            {
                get => books[index];
                set => books[index] = value;
            }
            
            public void TestInsertBookAt(Book book, int index)
            {
                this[index] = book;
            }
        }
    }

    namespace Indexer2Function.Solution
    {
        class BookLibrary
        {
            private Book[] books = new Book[1000];
            public void SetItem(int index, Book value) => books[index] = value;
            
            public Book GetItem(int index) => books[index];
            
            public void TestInsertBookAt(Book book, int index)
            {
                SetItem(index, book);
            }
        }
    }
}