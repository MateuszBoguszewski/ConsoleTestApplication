using ConsoleTestApplication;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MyTestProject
{
    class UniversityTests
    {
        [Test]
        public void CreateUniversity()
        {
            var student1 = new Student(1, "Milena");
            var student2 = new Student(2, "Mateusz");
            var students = new List<Student>();

            students.Add(student1);
            students.Add(student2);

            var department1 = new Department(1, "Informatyka", students);
            var department2 = new Department(2, "Elektryka", students);
            var derpartments = new List<Department>();

            derpartments.Add(department1);
            derpartments.Add(department2);

            var actual = new University(1, "PG", derpartments);

            Assert.IsTrue(actual.Id == 1 && actual.Name == "PG" && actual.Departments.Any(d => d.Id == 1 && d.Name == "Informatyka") && actual.Departments.FirstOrDefault(d => d.Id == 1 && d.Name == "Informatyka").Students.Any(s => s.Id == 1 && s.Name == "Milena"));
            Assert.IsTrue(actual.Id == 1 && actual.Name == "PG" && actual.Departments.Any(d => d.Id == 1 && d.Name == "Informatyka") && actual.Departments.FirstOrDefault(d => d.Id == 1 && d.Name == "Informatyka").Students.Any(s => s.Id == 2 && s.Name == "Mateusz"));
            Assert.IsTrue(actual.Id == 1 && actual.Name == "PG" && actual.Departments.Any(d => d.Id == 2 && d.Name == "Elektryka") && actual.Departments.FirstOrDefault(d => d.Id == 2 && d.Name == "Elektryka").Students.Any(s => s.Id == 1 && s.Name == "Milena"));
            Assert.IsTrue(actual.Id == 1 && actual.Name == "PG" && actual.Departments.Any(d => d.Id == 2 && d.Name == "Elektryka") && actual.Departments.FirstOrDefault(d => d.Id == 2 && d.Name == "Elektryka").Students.Any(s => s.Id == 2 && s.Name == "Mateusz"));
        }
        [Test]
        public void CreateStudent()
        {
            var student1 = new Student(1, "Milena");
            Assert.IsTrue(student1.Id == 1 && student1.Name == "Milena");
        }

        [Test]
        public void CreateDepartment()
        {
            var student1 = new Student(1, "Milena");
            var student2 = new Student(2, "Mateusz");

            var students = new List<Student>();

            students.Add(student1);
            students.Add(student2);

            var department1 = new Department(1, "Informatyka", students);

            Assert.IsTrue(department1.Id == 1 && department1.Name == "Informatyka" && department1.Students.Any(s => s.Id == 1 && s.Name == "Milena"));
            Assert.IsTrue(department1.Id == 1 && department1.Name == "Informatyka" && department1.Students.Any(s => s.Id == 2 && s.Name == "Mateusz"));
        }

    }
}
