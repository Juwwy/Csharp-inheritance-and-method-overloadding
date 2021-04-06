using System;
namespace InheritanceArrTest
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {
            
        }

        public string Explain()
        {
            return $"Mrs. {Name} explain the indept logic of ohm's law in his teaching and the student were listening very atttentively.";
        }
    }
}