using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Interface_to_Abstract_Class.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert 'Shape' interface into abstract class
    namespace Interface2Abstract.Task
    {
        interface Shape
        {
            double Area { get; }
            void Draw();
        }
        
        class Circle : Shape
        {
            private readonly int radius;
            public double Area => Math.PI * Math.Pow(radius, 2);
            public void Draw()
            {
                // do something
            }
        }
    }
    
    namespace Interface2Abstract.Solution
    {
        internal abstract class Shape
        {
            public abstract double Area { get; }
            public abstract void Draw();
        }

        class Circle : Shape
        {
            private readonly int radius;
            public override double Area => Math.PI * Math.Pow(radius, 2);
            public override void Draw()
            {
                // do something
            }
        }
    }
}