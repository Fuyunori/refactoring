using System;
using System.IO;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Introduce_Field.html
    
    // KEYBOARD SHORTCUT: Ctrl+R F
    
    // TASK: introduce field 'ErrorMessage' which contains the string constants in 'LogError' and 'PrintError' methods
    // note: the field should be a constant
    namespace IntroduceField.Task
    {
        class ErrorHandler
        {
            public static void LogError(Exception e)
            {
                File.WriteAllText(@"c:\Error.txt", "Something has failed" + e);
            }
            public static void PrintError(Exception e)
            {
                Console.WriteLine("{0} : {1}", "Something has failed", e);
            }
        }
    }
    
    namespace IntroduceField.Solution
    {
        class ErrorHandler
        {
            private const string ErrorMessage = "Something has failed";

            public static void LogError(Exception e)
            {
                File.WriteAllText(@"c:\Error.txt", ErrorMessage + e);
            }
            public static void PrintError(Exception e)
            {
                Console.WriteLine("{0} : {1}", ErrorMessage, e);
            }
        }
    }
}