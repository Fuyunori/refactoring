using System.Drawing;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Move__Instance_Method_to_Another_Type.html
    
    // KEYBOARD SHORTCUT: Ctrl+R O
    
    // TASK: move 'LogDrawing' method to the 'Logger' class
    namespace MoveInstanceMethod.Task
    {
        class Shape
        {
            private Point pivot;
            private void LogDrawing(Logger logger)
            {
                var msg = $"Shape is drawn at {pivot.X}, {pivot.Y}";
                logger.Log(msg);
            }
        }
        
        class Logger
        {
            public void Log(string msg)
            {
                // log the message
            }
        }
    }
    
    namespace MoveInstanceMethod.Solution
    {
        class Shape
        {
            private Point pivot;

            public Point Pivot
            {
                set { pivot = value; }
                get { return pivot; }
            }
        }
        
        class Logger
        {
            public void Log(string msg)
            {
                // log the message
            }

            private void LogDrawing(Shape shape)
            {
                var msg = $"Shape is drawn at {shape.Pivot.X}, {shape.Pivot.Y}";
                this.Log(msg);
            }
        }
    }
}