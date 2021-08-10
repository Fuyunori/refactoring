namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Make_Method_Non-Static.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert static method 'Merge' of the 'Info' class to an instance method
    // note: choose i1 as the instance parameter
    namespace MakeNonStatic.Task
    {
        class Info
        {
            string Id { get; set; }
            string Name { get; set; }
            
            static Info Merge(Info i1, Info i2)
            {
                return new Info
                {
                    Id = i1.Id + i2.Id,
                    Name = i1.Name + i2.Name
                };
            }
            
            void Test()
            {
                var i1 = new Info()
                    { Id = "123", Name = "AA" };
                var i2 = new Info()
                    { Id = "456", Name = "BB" };
                var merged =
                    Info.Merge(i1, i2);
            }
        }
    }
    
    namespace MakeNonStatic.Solution
    {
        class Info
        {
            string Id { get; set; }
            string Name { get; set; }

            public Info Merge(Info i2)
            {
                return new Info
                {
                    Id = Id + i2.Id,
                    Name = Name + i2.Name
                };
            }
            
            void Test()
            {
                var i1 = new Info()
                    { Id = "123", Name = "AA" };
                var i2 = new Info()
                    { Id = "456", Name = "BB" };
                var merged =
                    i1.Merge(i2);
            }
        }
    }
}