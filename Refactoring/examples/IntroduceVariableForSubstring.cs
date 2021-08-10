namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Introduce_Variable_for_Substring.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: introduce a local variable 'messageType' which replaces the "answer" part in the string constant
    namespace IntroduceVariableForSubstring.Task
    {
        public class IntroduceVariableForSubstring
        {
            public string GetMessage()
            {
                return "Please enter your answer";
            }
        }
    }
    
    namespace IntroduceVariableForSubstring.Solution
    {
        public class IntroduceVariableForSubstring
        {
            public string GetMessage()
            {
                var messageType = "answer";
                return $"Please enter your {messageType}";
            }
        }
    }
}