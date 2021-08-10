namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Encapsulate_Field.html
    
    // KEYBOARD SHORTCUT: Ctrl+R E
    
    // TASK: convert 'myString' field to an auto-property (i.e., encapsulate the field)
    namespace EncapsulateField.Task
    {
        public class EncapsulateField
        {
            private string myString;
            public void DoSomething(string input)
            {
                myString = input;
            }
        }
    }
    
    namespace EncapsulateField.Solution
    {
        public class EncapsulateField
        {
            public string MyString { get; private set; }

            public void DoSomething(string input)
            {
                MyString = input;
            }
        }
    }
}