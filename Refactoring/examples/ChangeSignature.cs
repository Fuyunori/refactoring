using System;

namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Change_Signature.html
    
    // change signature - this technique offers two possible options; refactor
    // 1) with updating the calls - i.e. update the call accordingly
    // 2) without updating the calls - the original call is preserved and a new (wrapping) method with the new signature is created
    // - option 2 is good when you want to leave the existing usages unchanged
    
    // KEYBOARD SHORTCUT: Ctrl+R S
    
    // TASK: change the signature of the method 'Foo' to have a new name 'Bar' and swap the parameters
    namespace ChangeSignature.Task
    {
        public class ChangeSignature
        {
            public string Foo(string s, int x)
            {
                return String.Format("'{0}': {1} times", s, x);
            }
        
            public void Test()
            {
                Foo("test", 10);
            }
        }
    }

    namespace ChangeSignature.Solution
    {
        public class ChangeSignatureWithUpdatingCallsSolution
        {
            public string Bar(int x, string s)
            {
                return String.Format("'{0}': {1} times", s, x);
            }
        
            public void Test()
            {
                Bar(10, "test");
            }
        }
    
        public class ChangeSignatureWithoutUpdatingCallsSolution
        {
            public string Foo(string s, int x)
            {
                return Bar(x, s);
            }

            public string Bar(int x, string s)
            {
                return String.Format("'{0}': {1} times", s, x);
            }
        
            public void Test()
            {
                Foo("test", 10);
            }
        }
    }
}