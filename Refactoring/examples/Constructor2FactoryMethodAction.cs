using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Replace_Constructor_with_Factory_Method.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: replace the constructor with a factory method named 'CreateFoo'
    // if you don't know what a factory method is, read here:
    // https://sourcemaking.com/design_patterns/factory_method
    namespace Constructor2FactoryMethodAction.Task
    {
        class Foo
        {
            public Foo()
            {
                // instance initialization
            }
        }
    }
    
    namespace Constructor2FactoryMethodAction.Solution
    {
        class Foo
        {
            private Foo()
            {
                // instance initialization
            }

            public static Foo CreateFoo()
            {
                return new Foo();
            }
        }
    }
}