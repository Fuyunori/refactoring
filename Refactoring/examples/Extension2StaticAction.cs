namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Extension_Method_to_Plain_Static.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert the extension method 'DoSomething' to a static method
    namespace Extension2StaticAction.Task
    {
        public static class Extension2StaticAction
        {
            public static void DoSomething(this string s)
            {
            }
            
            private static void Test(string str)
            {
                str.DoSomething();
            }
        }
    }

    namespace Extension2StaticAction.Solution
    {
        public static class Extension2StaticAction
        {
            public static void DoSomething(string s)
            {
            }
            
            private static void Test(string str)
            {
                DoSomething(str);
            }
        }
    }
}