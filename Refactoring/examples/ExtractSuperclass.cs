using System.Drawing;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Extract_Superclass.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: extract 'Color' property and 'Draw' method into a new class named 'Shape'
    // note: the method 'Draw' in the class 'Shape' should be abstract
    namespace ExtractSuperclass.Task
    {
        public class Circle : IDrawable
        {
            public Point Center { get; private set; }
            public Color MyColor { get; private set; }
            public int Radius { get; private set; }
            public void Draw()
            {
                // draw...
            }
        }
        public interface IDrawable
        {
            void Draw();
        }
    }
    
    namespace ExtractSuperclass.Solution
    {
        public abstract class Shape : IDrawable
        {
            public Color MyColor { get; private set; }
            public abstract void Draw();
        }

        public class Circle : Shape
        {
            public Point Center { get; private set; }
            public int Radius { get; private set; }
            public override void Draw()
            {
                // draw...
            }
        }
        public interface IDrawable
        {
            void Draw();
        }
    }
}