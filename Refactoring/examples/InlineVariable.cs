using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Inline_Variable.html
    
    // KEYBOARD SHORTCUT: Ctrl+R I
    
    // TASK: inline 'reversed' variable
    namespace InlineVariable.Task
    {
        public class InlineVariable
        {
            public static string ReversedString(string input)
            {
                var chars = input.ToCharArray();
                Array.Reverse(chars);
                var reversed = new string(chars);
                return reversed;
            }
        }
    }

    namespace InlineVariable.Solution
    {
        public class InlineVariable
        {
            public static string ReversedString(string input)
            {
                var chars = input.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
        }
    }
}