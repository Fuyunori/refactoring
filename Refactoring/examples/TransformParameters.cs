using System.Drawing;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings_Transform_Parameters.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: replace out parameter 'res' with method return and wrap the parameters 'ctr' and 'rad' with a new class
    // named 'Circle'
    namespace TransformParameters.Task
    {
        class TestClass
        {
            public void DrawCircle(Point ctr, float rad, out bool res)
            {
                // draw...
                res = true;
            }
        }
    }
    
    namespace TransformParameters.Solution
    {
        internal class Circle
        {
            public Circle(Point ctr, float rad)
            {
                Ctr = ctr;
                Rad = rad;
            }

            public Point Ctr { get; private set; }
            public float Rad { get; private set; }
        }

        class TestClass
        {
            public bool DrawCircle(Circle circle)
            {
                // draw...
                var res = true;
                return res;
            }
        }
    }
}