using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings_Invert_Boolean.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: invert the result of 'IsEven' inside the condition of 'Test' method and rename 'IsEven' to 'IsOdd'
    namespace InvertBool.Task
    {
        public class InvertBool
        {
            public bool IsEven(int input)
            {
                return input % 2 == 0;
            }
            
            public void Test(int value)
            {
                if (IsEven(value))
                    Console.WriteLine("\n the number is even");
            }
        }
    }
    
    namespace InvertBool.Solution
    {
        public class InvertBool
        {
            public bool IsOdd(int input)
            {
                return input % 2 != 0;
            }
            
            public void Test(int value)
            {
                if (!IsOdd(value))
                    Console.WriteLine("\n the number is even");
            }
        }
    }
}