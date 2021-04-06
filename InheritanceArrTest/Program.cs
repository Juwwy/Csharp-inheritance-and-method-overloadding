using System;

namespace InheritanceArrTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a name: ");
            string student1 = Console.ReadLine();

            Console.Write("Enter a name: ");
            string student2 = Console.ReadLine();

            Console.Write("Enter a name: ");
            string teacher = Console.ReadLine();

            Student studentA = new Student(student1);
            Student studentB = new Student(student2);

            Teacher teach = new Teacher(teacher);

            Person[] nameArr = {studentA, studentB, teach };

            // Person[] name = {student1, student2, teacher };

            foreach (Person item in nameArr)
            {
                Console.WriteLine($"{item}");
            }

            Console.Write($"\n{studentA.Study()}\n");
            Console.Write($"\n{studentB.Study()}\n");

            Console.Write($"\n{teach.Explain()}\n");




        //     Person[] names = new Person[3];

        //     for (int i = 0; i < 3; i++)
        //     {
        //         Console.Write("Enter a name: ");
        //         names[i] = (Person)Console.ReadLine();
        //     }

        //     // Person name = new Person(Person[names]);

        //     foreach (Person item in names)
        //     {
        //         Console.WriteLine($"{names[item]}");
        //     }
        }
    }
}
