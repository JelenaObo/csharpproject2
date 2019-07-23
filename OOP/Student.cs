using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace OOP
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Code { get; set; }

        public List<int> Grades { get; set; }=new List<int>();

        public string FullName(bool getShortName = false)
        {
            if (getShortName)
            {
                string fullname = "";
                if (!string.IsNullOrEmpty(Name)&& !string.IsNullOrEmpty(Surname))
                {
                    return $"{Name[0]} {Surname}";
                } else if (!string.IsNullOrEmpty(Name) && string.IsNullOrEmpty(Surname))
                {
                    return Name;
                }
                else
                {
                    return Surname;
                }
            }
            return $"{Name} {Surname}";
        }

        public static string GetStudentDescription(Student student)
        {
            return $"{student.Code} {student.Name} {student.Surname}";
        }

        public static string GenerateNewName(Student student1, Student student2)
        {
            return $"{student1.Name.Substring(0, 3)}{student2.Name.Substring(0, 3)}";
        }

        public double GetAveGrades()
        {
            return Grades.Average();
        }
    }
}
