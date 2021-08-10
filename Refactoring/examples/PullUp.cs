using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Pull_Members_Up.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: pull up the method 'Foo' from 'MyDerivedClass' tp 'IMyInterface' interface
    namespace PullUp.Task
    {
        interface IMyInterface
        {
        }
        
        class MyDerivedClass : IMyInterface
        {
            public void Foo()
            {
                Console.WriteLine("Hello");
            }
        }
    }
    
    namespace PullUp.Solution
    {
        interface IMyInterface
        {
            void Foo();
        }
        
        class MyDerivedClass : IMyInterface
        {
            public void Foo()
            {
                Console.WriteLine("Hello");
            }
        }
    }
}