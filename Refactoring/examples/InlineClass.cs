using System.Drawing;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Inline_Class.html
    
    // KEYBOARD SHORTCUT: Ctrl+R I
    
    // TASK: inline 'Painter' class inside the 'Circle' class
    namespace InlineClass.Task
    {
        class Painter
        {
            private Color myColor;
            public Painter(Color c)
            {
                myColor = c;
                InitPainter(myColor);
            }
            private void InitPainter(Color color)
            {
                //init painter
            }
        }
        
        class Circle
        {
            private Painter myPainter;
            public Circle(Color c)
            {
                myPainter = new Painter(c);
            }
        }
    }
    
    namespace InlineClass.Solution
    {
        class Circle
        {
            private Color myColor;

            public Circle(Color c)
            {
                myColor = c;
                InitPainter(myColor);
            }

            private void InitPainter(Color color)
            {
                //init painter
            }
        }
    }
}