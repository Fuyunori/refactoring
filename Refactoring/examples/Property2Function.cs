namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Property_to_Method.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert 'Faculty' auto-property to getter and setter methods
    namespace Property2Function.Task
    {
        class Student
        {
            public string Faculty { set; get; }
        }
    }
    
    namespace Property2Function.Solution
    {
        class Student
        {
            private string _faculty;

            public void SetFaculty(string value)
            {
                _faculty = value;
            }

            public string GetFaculty()
            {
                return _faculty;
            }
        }
    }
}