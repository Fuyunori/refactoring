using System;
using System.IO;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Introduce_Variable.html
    
    // KEYBOARD SHORTCUT: Ctrl+R V
    
    // TASK: introduce a local variable 'message' in the 'LogError' method which replaces the string "Something has failed..."
    namespace IntroduceVariable.Task
    {
        public class IntroduceVariable
        {
            static void LogError(Exception ex)
            {
                Console.WriteLine("Something has failed...");
                File.WriteAllText(@"c:\Error.txt", "Something has failed..." + ex);
            }
        }
    }
    
    namespace IntroduceVariable.Solution
    {
        public class IntroduceVariable
        {
            static void LogError(Exception ex)
            {
                var message = "Something has failed...";
                Console.WriteLine(message);
                File.WriteAllText(@"c:\Error.txt", message + ex);
            }
        }
    }
}