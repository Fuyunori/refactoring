using System.Drawing;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Extract_Interface.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: extract 'Color' property and 'Draw' method into a new interface named 'IShape'
    namespace ExtractInterface.Task
    {
        class Circle
        {
            public Point Center { get; private set; }
            public Color Color { get; private set; }
            public int Radius { get; private set; }
            public void Draw()
            {
                // draw...
            }
        }
    }
    
    namespace ExtractInterface.Solution
    {
        interface IShape
        {
            Color Color { get; }
            void Draw();
        }

        class Circle : IShape
        {
            public Point Center { get; private set; }
            public Color Color { get; private set; }
            public int Radius { get; private set; }
            public void Draw()
            {
                // draw...
            }
        }
    }
}