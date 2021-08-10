namespace Refactoring.examples
{
    // If you're stuck, visit:
    // https://www.jetbrains.com/help/resharper/Refactorings__Make_Method_Static.html
    
    // KEYBOARD SHORTCUT: Ctrl+Shift+R
    
    // TASK: convert instance method 'Merge' of the 'Info' class to a static method
    // note: in the new method, a new parameter is added
    namespace MakeStatic.Task
    {
        class Info
        {
            string Id { get; set; }
            string Name { get; set; }

            Info Merge(Info other)
            {
                return new Info
                {
                    Id = Id + other.Id,
                    Name = Name + other.Name
                };
            }

            void Test()
            {
                var i1 = new Info()
                    {Id = "123", Name = "AA"};
                var i2 = new Info()
                    {Id = "456", Name = "BB"};
                var merged = i1.Merge(i2);
            }
        }
    }
    
    namespace MakeStatic.Solution
    {
        class Info
        {
            string Id { get; set; }
            string Name { get; set; }

            static Info Merge(Info info, Info other)
            {
                return new Info
                {
                    Id = info.Id + other.Id,
                    Name = info.Name + other.Name
                };
            }

            void Test()
            {
                var i1 = new Info()
                    {Id = "123", Name = "AA"};
                var i2 = new Info()
                    {Id = "456", Name = "BB"};
                var merged = Merge(i1, i2);
            }
        }
    }
}