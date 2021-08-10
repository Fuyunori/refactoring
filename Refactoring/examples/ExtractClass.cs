using System;
using System.IO;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Extract_Class.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: extract 'LogError' method into a new class named 'Logger'
    namespace ExtractClass.Task
    {
        class Shape
        {
            public void Draw()
            {
                try { /*draw*/ }
                catch (Exception e) { LogError(e); }
            }
            public static void LogError(Exception e)
            {
                File.WriteAllText(@"c:\Errors\Exception.txt", e.ToString());
            }
        }
    }
    
    namespace ExtractClass.Solution
    {
        class Logger
        {
            public static void LogError(Exception e)
            {
                File.WriteAllText(@"c:\Errors\Exception.txt", e.ToString());
            }
        }

        class Shape
        {
            public void Draw()
            {
                try { /*draw*/ }
                catch (Exception e) {
                    Logger.LogError(e); }
            }
        }
    }
}