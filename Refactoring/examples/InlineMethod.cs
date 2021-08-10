using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Inline_Method.html
    
    // KEYBOARD SHORTCUT: Ctrl+R I
    
    // TASK: inline 'LogError' method
    namespace InlineMethod.Task
    {
        abstract class Shape
        {
            public void Draw()
            {
                try { /* draw */ }
                catch (Exception e)
                {
                    LogError(e);
                }
            }
            private static void LogError(Exception e)
            {
                File.WriteAllText(@"c:\Errors\Exception.txt", e.ToString());
            }
        }
    }

    namespace InlineMethod.Solution
    {
        abstract class Shape
        {
            public void Draw()
            {
                try { /* draw */ }
                catch (Exception e)
                {
                    File.WriteAllText(@"c:\Errors\Exception.txt", e.ToString());
                }
            }
        }
    }
}