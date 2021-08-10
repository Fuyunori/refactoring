namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Convert_Method_to_Property.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert 'GetFaculty' (and 'SetFaculty') to get (and set, respectively) accessors
    namespace Function2Property.Task
    {
        class Student
        {
            private string _faculty;
            public string GetFaculty()
            {
                return _faculty;
            }
            public void SetFaculty(string f)
            {
                _faculty = f;
            }
        }
    }
    
    namespace Function2Property.Solution
    {
        class Student
        {
            private string _faculty;

            public string Faculty
            {
                get { return _faculty; }
                set { _faculty = value; }
            }
        }
    }
}