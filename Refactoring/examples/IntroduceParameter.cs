using System;
using System.IO;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Introduce_Parameter.html
    
    // KEYBOARD SHORTCUT: Ctrl+R P
    
    // TASK: introduce a parameter 'message' in the 'LogError' method which replaces the string "Something has failed..."
    namespace IntroduceParameter.Task
    {
        abstract class Shape
        {
            public void Draw()
            {
                try { /*draw*/ }
                catch (Exception e)
                {
                    LogError(e);
                }
            }
            
            static void LogError(Exception ex)
            {
                Console.WriteLine("Something has failed...");
                File.WriteAllText(@"c:\Error.txt", "Something has failed..." + ex);
            }
        }
    }
    
    namespace IntroduceParameter.Solution
    {
        abstract class Shape
        {
            public void Draw()
            {
                try { /*draw*/ }
                catch (Exception e)
                {
                    LogError(e, "Something has failed...");
                }
            }
            
            static void LogError(Exception ex, string message)
            {
                Console.WriteLine(message);
                File.WriteAllText(@"c:\Error.txt", message + ex);
            }
        }
    }
}