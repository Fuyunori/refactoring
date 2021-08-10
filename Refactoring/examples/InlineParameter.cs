using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Inline_Parameter.html
    
    // KEYBOARD SHORTCUT: Ctrl+R I
    
    // TASK: inline 'pi' parameter
    namespace InlineParameter.Task
    {
        public class InlineParameter
        {
            private double AreaOfCircle(double rad, double pi)
            {
                return pi*rad*rad;
            }
            
            public void Test()
            {
                var area = AreaOfCircle(10, Math.PI);
            }
        }
    }
    
    namespace InlineParameter.Solution
    {
        public class InlineParameter
        {
            private double AreaOfCircle(double rad)
            {
                return Math.PI*rad*rad;
            }

            public void Test()
            {
                var area = AreaOfCircle(10);
            }
        }
    }
}