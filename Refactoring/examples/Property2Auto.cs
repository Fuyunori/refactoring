using System.Drawing;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Property_to_Auto-Property.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert !BackgroundColor! property to auto-property
    namespace Property2Auto.Task
    {
        class Shape
        {
            private Color bgColor;
            public Color BackgroundColor
            {
                get { return bgColor; }
                set { bgColor = value; }
            }
            public Shape(Color background)
            {
                bgColor = background;
            }
        }
    }
    
    namespace Property2Auto.Solution
    {
        class Shape
        {
            public Color BackgroundColor { get; set; }

            public Shape(Color background)
            {
                BackgroundColor = background;
            }
        }
    }
}