using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Inline_Field.html
    
    // KEYBOARD SHORTCUT: Ctrl+R I
    
    // TASK: inline 'ErrorMessage' field
    namespace InlineField.Task
    {
        class Shape
        {
            private const string ErrorMessage = "Something has failed";
            public void Draw(string s)
            {
                try { /*draw*/ }
                catch (Exception e)
                {
                    Console.WriteLine("{0} : {1}", ErrorMessage, e);
                }
            }
        }
    }
    
    namespace InlineField.Solution
    {
        class Shape
        {
            public void Draw(string s)
            {
                try { /*draw*/ }
                catch (Exception e)
                {
                    Console.WriteLine("{0} : {1}", "Something has failed", e);
                }
            }
        }
    }
}