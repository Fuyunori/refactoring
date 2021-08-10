using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Static_to_Extension_Method.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert 'Reverse' static method to an extension method
    namespace Static2ExtensionAction.Task
    {
        static class Foo
        {
            public static string Reverse(string input)
            {
                var chars = input.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
            
            static void Test(string str)
            {
                str = Reverse(str);
            }
        }
    }
    
    namespace Static2ExtensionAction.Solution
    {
        static class Foo
        {
            public static string Reverse(this string input)
            {
                var chars = input.ToCharArray();
                Array.Reverse(chars);
                return new string(chars);
            }
            
            static void Test(string str)
            {
                str = str.Reverse();
            }
        }
    }
}