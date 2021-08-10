using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Extract_Method.html
    
    // KEYBOARD SHORTCUT: Ctrl+R M
    
    // TASK: extract the logic for reversing into a separate method
    namespace ExtractMethod.Task
    {
        public class ExtractMethod
        {
            public static void PrintReversed(string input)
            {
                var chars = input.ToCharArray();
                Array.Reverse(chars);
                var reversed =  new string(chars);
                Console.WriteLine(reversed);
            }
        }
    }

    namespace ExtractMethod.Solution
    {
        public class ExtractMethod
        {
            public static void PrintReversed(string input)
            {
                var reversed = ReverseStr(input);
                Console.WriteLine(reversed);
            }

            private static string ReverseStr(string input)
            {
                var chars = input.ToCharArray();
                Array.Reverse(chars);
                var reversed = new string(chars);
                return reversed;
            }
        }
    }
}