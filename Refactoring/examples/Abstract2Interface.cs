namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Abstract_Class_to_Interface.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert 'CachedItem' class to interface
    namespace Abstract2Interface.Task
    {
        public abstract class CachedItem
        {
            public abstract int Id { get; set; }
            public abstract void Register();
            public abstract void UnRegister();
        }
    }
    
    namespace Abstract2Interface.Solution
    {
        public interface CachedItem
        {
            int Id { get; set; }
            void Register();
            void UnRegister();
        }
    }
}