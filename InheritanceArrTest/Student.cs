using System;
namespace InheritanceArrTest
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
            
        }

        public string Study()
        {
            return $"{Name} is writing as the teacher was dictating to the class.";
        }
    }
}