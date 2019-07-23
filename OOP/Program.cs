using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]{"Gusts", "Peteris"};
            string[] surnames = new string[] { "Ozols", "Liepa" };
            string[] codes = new string[] { "111111", "222222" };

            int[] grades1 = new[] {2, 4, 5, 6};
            int[] grades2 = new[] {6,8,9,5,6};

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i] + surnames[i] +codes[i]);
            //}

            Student student1 = new Student();

            student1.Name = "Gusts";
            student1.Surname = "Ozols";
            student1.Code = "111111";

            student1.Grades.Add(2);
            student1.Grades.Add(6);
            student1.Grades.Add(5);
            student1.Grades.Add(7);


            //Console.WriteLine(student1.Name);

            Student student2 = new Student();

            student2.Name = "Peteris";
            student2.Surname = "Liepa";
            student2.Code = "222222";

            student2.Grades.Add(5);
            student2.Grades.Add(6);
            student2.Grades.Add(8);
            student2.Grades.Add(9);

            //Console.WriteLine(student2.Name);

            Student[] students = new[] {student1, student2};
            List<Student> studentlist = new List<Student>();

            studentlist.Add(student1);
            studentlist.Add(student2);

            foreach (var student in studentlist)
            {
                Console.WriteLine(student.FullName());
                Console.WriteLine(student.FullName(true));
                Console.WriteLine(student.GetAveGrades());

                //var fullname = student1.FullName();
                //var studentDescription = Student.GetStudentDescription(student1);

                //Student.GenerateNewName(student1, student2);
            }
        }
    }
}
